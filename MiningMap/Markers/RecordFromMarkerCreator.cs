using BusinesLogic;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;

namespace MiningMap
{
    /// <summary>
    /// Класс, подготавливающий данные по маркерам для записи в БД
    /// </summary>
    public static class RecordFromMarkerCreator
    {
        /// <summary>
        /// Сформировать данные о маркере для записи в базу данных
        /// </summary>
        /// <param name="MapMarker">Маркер на карте</param>
        /// <returns></returns>
        public static TechnicRecord CreateRecord(GMarkerGoogle MapMarker)
        {
            int id = (int)MapMarker.Tag;
            double latitude = MapMarker.Position.Lat;
            double longtitude = MapMarker.Position.Lng;
            string type = MapMarker.ToolTipText;
            Color color = ColorAndMarkerTypeConverter.GetMarkerColor(MapMarker.Type);

            var record = new TechnicRecord(id, type, new Coordinate(latitude, longtitude), color);
            return record;
        }

        /// <summary>
        /// Сформировать данные о нескольких маркерах для записи информации о них в базу данных
        /// </summary>
        /// <param name="MapMarkers">Список маркеров, информацию по которым необходимо обновить/добавить</param>
        /// <returns></returns>
        public static List<TechnicRecord> CreateRecordsList(List<GMarkerGoogle> MapMarkers)
        {
            var output = new List<TechnicRecord>();

            for (int i = 0; i < MapMarkers.Count; i++)
            {
                var record = CreateRecord(MapMarkers[i]);
                output.Add(record);
            }

            return output;
        }
    }
}
