using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using BusinesLogic;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace MiningMap
{
    /// <summary>
    /// Класс презентера, осуществляющего взаимодействие бизнес-логики и графического интерфейса
    /// </summary>
    public class Presenter
    {
        #region Закрытые поля
        /// <summary>
        /// Главная форма приложения (UI)
        /// </summary>
        private IForm _view;

        /// <summary>
        /// Наблюдатель за изменениями файла, в который эмулятор GPS-трекера записывает данные
        /// </summary>
        private FileSystemWatcher _emulationFileWatcher;
        #endregion

        #region Конструктор
        public Presenter(IForm View)
        {
            _view = View;
            _view.FormLoaded += MainFormLoaded;
            _view.FormIsClosing += MainFormIsClosing;
        }

        #endregion

        #region Обработка событий

        /// <summary>
        /// Основное окно полностью загрузилось
        /// </summary>
        private async void MainFormLoaded(object sender, EventArgs e)
        {
            /// Использование связки async void - плохая практика, но при обработке событий по другому не получается
            try
            {
                List<TechnicRecord> markersInfo = await LoadDataFromDBAsync();
                GMapOverlay markersOverlay = MapOverlayManager.GetOverlayMarkers(markersInfo);
                _view.AddMarkersOnTheMap(markersOverlay);
                InitializeFileWatcher();
            }
            catch
            {
                _view.ShowWarningMessage("Возникла ошибка при попытке загрузки данных из БД!");
            }
        }

        /// <summary>
        /// Основное окно закрывается, необходимо обновить БД
        /// </summary>
        private async void MainFormIsClosing(object sender, EventArgs e)
        {
            try
            {
                List<TechnicRecord> updatedRecords = RecordFromMarkerCreator.CreateRecordsList(_view.UpdatedMarkers);
                if (updatedRecords.Count == 0)
                {
                    return;
                }
                await DataBaseConnector.UpdateMarkerInfo(updatedRecords);
            }
            catch
            {
                _view.ShowWarningMessage("Возникла ошибка при попытке обновления данных в БД!");
            }
        }

        /// <summary>
        /// Файл с данными в формате NMEA был обновлён, необходимо обновить маркер
        /// </summary>
        private void WatchedMachinaryPositionWasUpdated(object sender, FileSystemEventArgs e)
        {
            Coordinate newCoordinates = ParserGPS.DecodeLastData();
            PointLatLng newPoint = new PointLatLng(newCoordinates.Latitude, newCoordinates.Longtitude);
            // В данном примере изменяем расположение первого маркера
            _view.UpdateMarkerPosition(1, newPoint);
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Загрузка данных о расположении техники из БД
        /// </summary>
        /// <returns></returns>
        private async Task<List<TechnicRecord>> LoadDataFromDBAsync()
        {
            var list = await DataBaseConnector.ReadDataAsync();
            return list;
        } 

        /// <summary>
        /// Инициализация наблюдения за файлом, в который записываются GPS данные от одной единицы техники
        /// </summary>
        private void InitializeFileWatcher()
        {
            string solutiondir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string fileName = ParserGPS.FileName;

            _emulationFileWatcher = new FileSystemWatcher();
            _emulationFileWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size;
            _emulationFileWatcher.Path = solutiondir;
            _emulationFileWatcher.Filter = fileName;
            _emulationFileWatcher.Changed += WatchedMachinaryPositionWasUpdated;
            _emulationFileWatcher.EnableRaisingEvents = true;
        }

        #endregion
    }
}
