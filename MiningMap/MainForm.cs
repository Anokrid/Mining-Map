using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiningMap
{
    /// <summary>
    /// Главное окно приложения
    /// </summary>
    public partial class MainForm : Form, IForm
    {
        /// <summary>
        /// Было ли создано окно настроек
        /// </summary>
        public static bool SettingsFormWasCreated;

        #region Закрытые поля
        /// <summary>
        /// Выбранный маркер
        /// </summary>
        private GMapMarker _selectedMarker;

        /// <summary>
        /// Области на карте
        /// </summary>
        private AreaManager _areaManager;

        /// <summary>
        /// Координаты границ выделенной области
        /// </summary>
        private NumericUpDown[,] _areaPointsCoordinates;

        /// <summary>
        /// Действие, совершаемое при заезде маркера в выделенную зону
        /// </summary>
        private IAreaAction _areaExtraAction;

        #endregion

        #region Конструктор
        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            _areaExtraAction = new MessageCreater();

            _areaManager = new AreaManager();
            #region Заполнения массива контролов координат выделенной области
            _areaPointsCoordinates = new NumericUpDown[4, 2];
            _areaPointsCoordinates[0, 0] = numeric1PointX;
            _areaPointsCoordinates[0, 1] = numeric1PointY;
            _areaPointsCoordinates[1, 0] = numeric2PointX;
            _areaPointsCoordinates[1, 1] = numeric2PointY;
            _areaPointsCoordinates[2, 0] = numeric3PointX;
            _areaPointsCoordinates[2, 1] = numeric3PointY;
            _areaPointsCoordinates[3, 0] = numeric4PointX;
            _areaPointsCoordinates[3, 1] = numeric4PointY;

            for (int i = 0; i < 4; i++)
            {
                _areaPointsCoordinates[i, 0].Value = _areaManager.GetPointCoordinate(i, false);
                _areaPointsCoordinates[i, 1].Value = _areaManager.GetPointCoordinate(i, true);
            }
            #endregion

            UpdatedMarkers = new List<GMarkerGoogle>();
        } 
        #endregion

        #region Реализация интерфейса IForm

        public event EventHandler FormLoaded;

        public event EventHandler FormIsClosing;

        public List<GMarkerGoogle> UpdatedMarkers { get; set; }

        public void AddMarkersOnTheMap(GMapOverlay MarkersOverlay)
        {
            gMapControl.Overlays.Add(MarkersOverlay);
            gMapControl.Update();
            foreach (var marker in gMapControl.Overlays[1].Markers)
            {
                gMapControl.UpdateMarkerLocalPosition(marker);
            }
        }

        public void ShowWarningMessage(string Message)
        {
            MessageBox.Show(Message, "Возникла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void UpdateMarkerPosition(int MarkerId, PointLatLng NewPosition)
        {
            foreach (var marker in gMapControl.Overlays[1].Markers)
            {
                if (marker.Tag.ToString() == MarkerId.ToString())
                {
                    marker.Position = NewPosition;
                    gMapControl.UpdateMarkerLocalPosition(marker);
                    DoActionAfterMarkerWasUpdated(marker);
                    return;
                }
            }
        }

        #endregion

        #region Обработка событий

        private void MapLoaded(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;  //выбор подгрузки карты – онлайн или из ресурсов
            gMapControl.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 
            gMapControl.MinZoom = 2;    //минимальный зум
            gMapControl.MaxZoom = 16;   //максимальный зум
            gMapControl.Zoom = 4;       //какой используется зум при открытии
            gMapControl.Position = new GMap.NET.PointLatLng(66.4169575018027, 94.25025752215694);// точка в центре карты при открытии (центр России)
            gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
            gMapControl.CanDragMap = true; // перетаскивание карты мышью
            gMapControl.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl.ShowTileGridLines = false; //показывать или скрывать тайлы

            gMapControl.Overlays.Add(_areaManager.AreaOverlay);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    _areaPointsCoordinates[i, j].ValueChanged += areaCoordinateChanged;
                }
            }

            if (FormLoaded != null) FormLoaded(this, EventArgs.Empty);
        }

        private void gMapMouseDown(object sender, MouseEventArgs e)
        {
            _selectedMarker = gMapControl.Overlays.SelectMany(o => o.Markers).FirstOrDefault(m => m.IsMouseOver);
        }

        private void gMapMouseUp(object sender, MouseEventArgs e)
        {
            if (_selectedMarker is null)
            {
                return;
            }

            DoActionAfterMarkerWasUpdated(_selectedMarker);
            _selectedMarker = null;
        }

        private void gMapMouseMove(object sender, MouseEventArgs e)
        {
            if (_selectedMarker is null)
            {
                return;
            }
            var newCoordinates = gMapControl.FromLocalToLatLng(e.X, e.Y);
            _selectedMarker.Position = newCoordinates;
        }

        private void mainFormIsClosing(object sender, FormClosingEventArgs e)
        {
            if (FormIsClosing != null) FormIsClosing(this, EventArgs.Empty);
        }

        private void openSettingWindow(object sender, EventArgs e)
        {
            if (!SettingsFormWasCreated)
            {
                SettingsForm settingsForm = new SettingsForm();
                settingsForm.Location = Location;
                settingsForm.Show();
                SettingsFormWasCreated = true;
            }
        }

        private void areaCoordinateChanged(object sender, EventArgs e)
        {
            var control = sender as NumericUpDown;
            string controlTag = control.Tag.ToString();
            int pointNumber = controlTag[0] - '0';
            bool isLatitude = controlTag[1] == 'Y';
            _areaManager.ChangePointCoordinates(control.Value, pointNumber, isLatitude);
        }

        private void actionChangedToShowWindow(object sender, EventArgs e)
        {
            _areaExtraAction = new MessageCreater();
        }

        private void actionChangedToChangeColors(object sender, EventArgs e)
        {
            _areaExtraAction = new MarkerColorChanger();
        }

        private void actionChangedToCreateRandom(object sender, EventArgs e)
        {
            _areaExtraAction = new RandomMarkerCreator();
        }
        #endregion

        /// <summary>
        /// Выполнить следующие дествия в случае изменения положения маркера:
        /// <para>1) Проверить, не заехал ли маркер в особую зону, и если да, то выполнить определённое действие</para>
        /// <para>2) Добавить маркер в список обновлённых марекров, если его там нет</para>
        /// </summary>
        /// <param name="marker">Маркер, положение которого было обновлено</param>
        private void DoActionAfterMarkerWasUpdated(GMapMarker marker)
        {
            if (_areaManager.IsMarkerInsideArea(marker))
            {
                _areaExtraAction.DoAction(marker as GMarkerGoogle, gMapControl);
            }

            if (!UpdatedMarkers.Contains(marker))
            {
                UpdatedMarkers.Add(marker as GMarkerGoogle);
            }
        }
    }
}
