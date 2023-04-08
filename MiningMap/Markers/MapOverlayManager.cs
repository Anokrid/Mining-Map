using System.Collections.Generic;
using BusinesLogic;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace MiningMap
{
    /// <summary>
    /// Класс, создающий оверлей на карте, содержащий маркеры
    /// </summary>
    public static class MapOverlayManager
    {
        /// <summary>
        /// Получить оверлей, содержащий маркеры, которые необходимо добавить на карту
        /// </summary>
        /// <param name="MarkersInfo">Список, содеращий информацию о маркерах</param>
        /// <returns></returns>
        public static GMapOverlay GetOverlayMarkers(List<TechnicRecord> MarkersInfo)
        {
            GMapOverlay overlay = new GMapOverlay("MarkersOverlay");
            for (int i = 0; i < MarkersInfo.Count; i++)
            {
                GMarkerGoogle marker = MarkerCreator.CreateMarker(MarkersInfo[i]);
                overlay.Markers.Add(marker);
            }
            return overlay;
        }
    }
}
