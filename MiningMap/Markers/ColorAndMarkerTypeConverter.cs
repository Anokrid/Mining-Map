using BusinesLogic;
using GMap.NET.WindowsForms.Markers;
using System;

namespace MiningMap
{
    /// <summary>
    /// Конвертер цвета маркера в его тип и обратно
    /// </summary>
    public static class ColorAndMarkerTypeConverter
    {
        /// <summary>
        /// Перечень всех возможных типов маркеров
        /// </summary>
        private static GMarkerGoogleType[] _colors;

        static ColorAndMarkerTypeConverter()
        {
            _colors = new GMarkerGoogleType[9];
            _colors[0] = GMarkerGoogleType.none;
            _colors[1] = GMarkerGoogleType.blue;
            _colors[2] = GMarkerGoogleType.green;
            _colors[3] = GMarkerGoogleType.lightblue;
            _colors[4] = GMarkerGoogleType.orange;
            _colors[5] = GMarkerGoogleType.pink;
            _colors[6] = GMarkerGoogleType.purple;
            _colors[7] = GMarkerGoogleType.red;
            _colors[8] = GMarkerGoogleType.yellow;
        }

        /// <summary>
        /// Конвертация цвета маркера в его тип
        /// </summary>
        /// <param name="MarkersColor">Желаемый цвет маркера</param>
        /// <returns></returns>
        public static GMarkerGoogleType GetMarkerType(Color MarkersColor)
        {
            int id = (int)MarkersColor;
            return _colors[id];
        }

        /// <summary>
        /// Конвертация типа маркера в его цвет
        /// </summary>
        /// <param name="MarkerType">Тип маркера на карте</param>
        /// <returns></returns>
        public static Color GetMarkerColor(GMarkerGoogleType MarkerType)
        {
            int id = Array.IndexOf(_colors, MarkerType);
            return (Color)id;
        }
    }
}
