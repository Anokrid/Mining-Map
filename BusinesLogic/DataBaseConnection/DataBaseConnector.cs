using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Configuration;

namespace BusinesLogic
{
    /// <summary>
    /// Класс, отвечающий за взаимодействие с базой данных, в которой хранятся данные о расположении техники
    /// </summary>
    public static class DataBaseConnector
    {     
        /// <summary>
        /// Получить данные о расположении техники
        /// </summary>
        /// <returns></returns>
        public static async Task<List<TechnicRecord>> ReadDataAsync()
        {
            var output = new List<TechnicRecord>();

            string connectionString = FormConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string sqlExpression = "SELECT MachinaryiD, MachineryName, PositionLat, PositionLng, MarkerColor FROM MachineryTypes, Machinary WHERE MachineryTypes.MachineryTypeId = Machinary.MachineryType";
                
                try
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            var record = TechnicRecordCreator.FormMarkerInfo(reader);
                            output.Add(record);
                        }
                    }
                }
                catch
                {
                    // Сообщение об ошибке пускай передаёт презентер
                }
            }

            return output;
        }

        /// <summary>
        /// Сформировать строку подключения к базе данных
        /// </summary>
        /// <returns></returns>
        private static string FormConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            //string connectionString = "Data Source=DESKTOP-9V2UCI3\\SQLEXPRESS;Initial Catalog=TransportDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return connectionString;
        }

        /// <summary>
        /// Обновить информацию в БД по всем передвинутым маркерам
        /// </summary>
        /// <param name="UpdatedRecords">Новая информация по передвинутым маркерам</param>
        /// <returns></returns>
        public static async Task UpdateMarkerInfo(List<TechnicRecord> UpdatedRecords)
        {
            string connectionString = FormConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    string sqlExpression = "UPDATE Machinary SET PositionLat=@lat, PositionLng=@lng, MarkerColor=@color  WHERE MachinaryiD=@recordId";
                    for (int i = 0; i < UpdatedRecords.Count; i++)
                    {
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        command.Parameters.AddWithValue("@lat", UpdatedRecords[i].Position.Latitude);
                        command.Parameters.AddWithValue("@lng", UpdatedRecords[i].Position.Longtitude);
                        command.Parameters.AddWithValue("@color", (int)UpdatedRecords[i].MarkerColor);
                        command.Parameters.AddWithValue("@recordId", UpdatedRecords[i].Id);
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    // Сообщение об ошибке пускай передаёт презентер
                }
            }
        }

        public static async Task<Coordinate> ReadMachinaryPosition(int MachinaryId)
        {
            string connectionString = FormConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string sqlExpression = "SELECT PositionLat, PositionLng FROM Machinary WHERE Machinary.MachinaryiD=@id";

                try
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.Parameters.AddWithValue("@id", MachinaryId);
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            double lat = reader.GetDouble(0);
                            double lng = reader.GetDouble(1);
                            return new Coordinate(lat, lng);
                        }
                    }
                }
                catch
                {
                    // Сообщение об ошибке пускай передаёт презентер
                }
            }
            return new Coordinate();
        }
    }
}
