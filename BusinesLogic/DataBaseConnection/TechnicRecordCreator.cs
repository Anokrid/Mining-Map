using Microsoft.Data.SqlClient;
using System;

namespace BusinesLogic
{
    /// <summary>
    /// Класс, формирующий информация о маркере, отображающему технику на карте, на основании информации, загруженной из БД
    /// </summary>
    public static class TechnicRecordCreator
    {
        /// <summary>
        /// Сформировать информацию о маркере
        /// </summary>
        /// <param name="reader">Информация, загруженная из БД</param>
        /// <returns></returns>
        public static TechnicRecord FormMarkerInfo(SqlDataReader reader)
        {
            int id = (int)reader.GetValue(0);
            string machineryType = reader.GetValue(1).ToString();
            double lat = Convert.ToDouble(reader.GetValue(2));
            double lng = Convert.ToDouble(reader.GetValue(3));
            int color = (int)reader.GetValue(4);
            return new TechnicRecord(id, machineryType, new Coordinate(lat, lng), (Color)color);
        }
    }
}
