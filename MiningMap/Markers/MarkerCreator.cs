using GMap.NET.WindowsForms.Markers;
using BusinesLogic;
using GMap.NET.WindowsForms;
using GMap.NET;
using System;

namespace MiningMap
{
    /// <summary>
    /// Класс, создающий маркер для размещения на карте на основании данных, взятых из базы данных
    /// </summary>
    public static class MarkerCreator
    {
        /// <summary>
        /// Создать маркер, размещаемый на карте
        /// </summary>
        /// <param name="InfoAboutMarker">Параметры маркера (координаты, цвет, текст)</param>
        /// <returns></returns>
        public static GMarkerGoogle CreateMarker(TechnicRecord InfoAboutMarker)
        {
            GMarkerGoogleType markerType = ColorAndMarkerTypeConverter.GetMarkerType(InfoAboutMarker.MarkerColor);
            var coordinates = new PointLatLng(InfoAboutMarker.Position.Latitude, InfoAboutMarker.Position.Longtitude);
            GMarkerGoogle marker = new GMarkerGoogle(coordinates, markerType);
            marker.ToolTip = new GMapToolTip(marker);
            marker.ToolTipText = InfoAboutMarker.TechicType;
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.Tag = InfoAboutMarker.Id;

            return marker;
        }

        /// <summary>
        /// Клонировать старый маркер, изменив его тип
        /// </summary>
        /// <param name="OldMarker">Старый маркер, параметры которого необходимо скопировать</param>
        /// <param name="NewMarkerType">Новый тип маркера</param>
        /// <returns></returns>
        public static GMarkerGoogle CloneMarkerWithNewType(GMarkerGoogle OldMarker, GMarkerGoogleType NewMarkerType)
        {
            var newMarker = new GMarkerGoogle(OldMarker.Position, NewMarkerType);
            newMarker.Tag = OldMarker.Tag;
            newMarker.ToolTipText = OldMarker.ToolTipText;
            newMarker.ToolTipMode = OldMarker.ToolTipMode;
            return newMarker;
        }

        /// <summary>
        /// Создать маркер в случайном месте в указанной области
        /// </summary>
        /// <param name="TopLeftPoint">Координаты верхней левой точки карты</param>
        /// <param name="BottomRightPoint">Координаты нижней правой токи карты</param>
        /// <param name="MarkerId">Идетификационный номер нового маркера</param>
        /// <returns></returns>
        public static GMarkerGoogle CreateMarkerAtRandomSpot(PointLatLng TopLeftPoint, PointLatLng BottomRightPoint, int MarkerId)
        {
            double minLat = Math.Min(TopLeftPoint.Lat, BottomRightPoint.Lat);
            double maxLat = Math.Max(TopLeftPoint.Lat, BottomRightPoint.Lat);
            double minLng = Math.Min(TopLeftPoint.Lng, BottomRightPoint.Lng);
            double maxLng = Math.Max(TopLeftPoint.Lng, BottomRightPoint.Lng);

            double lat = RandomDoubleGenerator.GetRandomNumber(minLat, maxLat);
            double lng = RandomDoubleGenerator.GetRandomNumber(minLng, maxLng);
            var coordinates = new PointLatLng(lat, lng);
            GMarkerGoogle marker = new GMarkerGoogle(coordinates, GMarkerGoogleType.red);
            marker.ToolTip = new GMapToolTip(marker);
            marker.ToolTipText = "Случайно созданный маркер";
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.Tag = MarkerId;

            return marker;
        }
    }
}
