using GMap.NET.WindowsForms.Markers;
using System;
using BusinesLogic;
using GMap.NET.WindowsForms;

namespace MiningMap
{
    /// <summary>
    /// Класс, изменяющий цвет маркера на случайный
    /// </summary>
    public class MarkerColorChanger : IAreaAction
    {
        public void DoAction(GMarkerGoogle gMapMarker, GMapControl gMapControl)
        {
            var random = new Random();
            int newColorId = random.Next(1, 9); // Доступных цветов всего 8
            Color newColor = (Color)newColorId;
            GMarkerGoogleType markerType = ColorAndMarkerTypeConverter.GetMarkerType(newColor);

            var newMarker = MarkerCreator.CloneMarkerWithNewType(gMapMarker, markerType);
            var gMapOverlay = gMapControl.Overlays[1];
            gMapOverlay.Markers.Remove(gMapMarker);
            gMapOverlay.Markers.Add(newMarker);
        }
    }
}
