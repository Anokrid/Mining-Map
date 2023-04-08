using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;

namespace MiningMap
{
    /// <summary>
    /// Интерфейс основного окна приложения
    /// </summary>
    public interface IForm
    {
        /// <summary>
        /// Событие, возникаемое при полной загрузке формы, включая MapControl
        /// </summary>
        event EventHandler FormLoaded;

        /// <summary>
        /// Событиве, вызываемое при начале закрытия формы
        /// </summary>
        event EventHandler FormIsClosing;

        /// <summary>
        /// Маркеры, положение которых было обновлено
        /// </summary>
        List<GMarkerGoogle> UpdatedMarkers { get; set; }

        /// <summary>
        /// Добавить маркеры на карту
        /// </summary>
        /// <param name="MarkersOverlay"></param>
        void AddMarkersOnTheMap(GMapOverlay MarkersOverlay);

        /// <summary>
        /// Показать сообщение с ошибкой
        /// </summary>
        /// <param name="Message">Сообщение, отображаемое в диалоговом окне</param>
        void ShowWarningMessage(string Message);

        /// <summary>
        /// Обновить позицию маркера на карте
        /// </summary>
        /// <param name="MarkerId">Id маркера</param>
        /// <param name="NewPosition">Новое расположение маркера</param>
        void UpdateMarkerPosition(int MarkerId, PointLatLng NewPosition);
    }
}
