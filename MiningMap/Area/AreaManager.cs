using GMap.NET;
using GMap.NET.WindowsForms;
using System.Collections.Generic;
using System.Drawing;

namespace MiningMap
{
    /// <summary>
    /// Класс, отвечающий за управление выделенной областью
    /// </summary>
    public class AreaManager
    {
        public GMapOverlay AreaOverlay;
        private SolidBrush _polygonFill;
        private Pen _polygonStroke;

        public AreaManager()
        {
            AreaOverlay = new GMapOverlay("polygons");
            var points = new List<PointLatLng>();
            points.Add(new PointLatLng(60.00, 80.00));
            points.Add(new PointLatLng(65.00, 80.00));
            points.Add(new PointLatLng(65.00, 90.00));
            points.Add(new PointLatLng(60.00, 90.00));
            GMapPolygon polygon = new GMapPolygon(points, "RedArea");
            _polygonFill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Fill = _polygonFill;
            _polygonStroke = new Pen(Color.Red, 1);
            polygon.Stroke = _polygonStroke;
            AreaOverlay.Polygons.Add(polygon);
        }

        /// <summary>
        /// Получить координаты точки полигона выделенной области
        /// </summary>
        /// <param name="PointNumber">Номер точки (от 0 до 3)</param>
        /// <param name="IsLatitude">Запрашивается ли широта, или долгота
        /// <para><b>true</b> - запрашивается широта (latitude)</para>
        /// <para><b>false</b> - запрашивается долгота (longtude)</para></param>
        /// <returns></returns>
        public decimal GetPointCoordinate(int PointNumber, bool IsLatitude = true)
        {
            var point = AreaOverlay.Polygons[0].Points[PointNumber];
            return IsLatitude ? (decimal)point.Lat : (decimal)point.Lng;
        }

        /// <summary>
        /// Изменить координаты одной из точек полигона
        /// </summary>
        /// <param name="NewValue">Новое значение координаты</param>
        /// <param name="PointNumber">Номер точки (от 0 до 3)</param>
        /// <param name="IsLatitude">Запрашивается ли широта, или долгота
        /// <para><b>true</b> - запрашивается широта (latitude)</para>
        /// <para><b>false</b> - запрашивается долгота (longtude)</para></param>
        public void ChangePointCoordinates(decimal NewValue, int PointNumber, bool IsLatitude = true)
        {
            var points = AreaOverlay.Polygons[0].Points;
            points[PointNumber] = IsLatitude ? new PointLatLng((double)NewValue, points[PointNumber].Lng) :
                points[PointNumber] = new PointLatLng(points[PointNumber].Lat, (double)NewValue);

            AreaOverlay.Polygons[0] = new GMapPolygon(points, "RedArea");
            AreaOverlay.Polygons[0].Fill = _polygonFill;
            AreaOverlay.Polygons[0].Stroke = _polygonStroke;
        }

        /// <summary>
        /// Находится ли маркер в выделенной области
        /// </summary>
        /// <param name="gMapMarker">Маркер, который проверяется</param>
        /// <returns></returns>
        public bool IsMarkerInsideArea(GMapMarker gMapMarker)
        {
            return AreaOverlay.Polygons[0].IsInside(gMapMarker.Position);
        }
    }
}
