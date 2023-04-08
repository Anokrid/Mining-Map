using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    /// <summary>
    /// Класс, отвечающий за чтение и запись данных в формате NMEA
    /// </summary>
    public static class ParserGPS
    {
        /// <summary>
        /// Имя файла, в который записываются данные об изменении местоположения техники
        /// </summary>
        public static string FileName => "GPS data.txt";
        public static string FullFileName => GetFullFileName();

        static ParserGPS()
        {
            using (FileStream fs = File.Open(FullFileName, FileMode.Open))
            {
                fs.SetLength(0);
                fs.Close();
            }
        }

        /// <summary>
        /// Закодировать текущую позицию техники в формат NMEA и записать сообщение в файл
        /// </summary>
        /// <param name="NewPosition"></param>
        public static void EncodeData(Coordinate NewPosition)
        {
            string encodedMessage = FormMessage(NewPosition);
            using (StreamWriter sw = File.AppendText(FullFileName))
            {
                sw.WriteLine(encodedMessage);
            }
        }

        /// <summary>
        /// Сформировать сообщение в формате NMEA для записи в файл
        /// </summary>
        /// <param name="NewPosition">Новая позиция техники</param>
        /// <returns></returns>
        private static string FormMessage(Coordinate NewPosition)
        {
            var message = new StringBuilder();
            message.Append("$GPGGA,");
            // 1 - Время UTC в формате "ЧЧММСС.ССС".
            string time = System.DateTime.UtcNow.ToString("hhmmss.sss");
            message.Append(time).Append(",");
            // 2 - Широта в формате "ГГММ.МММММ"
            // 3 - Направление широты: 'N'-север / 'S'-юг
            string lat = ConvertDoubleToFormatNMEA(NewPosition.Latitude, false);
            message.Append(lat).Append(",N,");
            // 4 - Долгота в формате "ГГГММ.МММММ"
            // 5 - Направление долготы: 'E'-восток / 'W'-запад
            string lng = ConvertDoubleToFormatNMEA(NewPosition.Longtitude, true);
            message.Append(lng).Append(",E,");
            // 6 - Способ вычисления координат ('8' - режим симуляции)
            message.Append("8,");
            // 7 - Количество активных спутников, от "00" до "12"
            message.Append("3,");
            // 8 - Горизонтальный геометрический фактор ухудшения точности (HDOP)
            message.Append("0.8,");
            // 9,10 - Высота над уровнем моря (geoid), единицы измерения высоты
            message.Append("236.4,M,");
            // 11,12 - Разница между эллипсоидом земли и уровнем моря (geoid)
            message.Append("46.9,M,");
            // 13 - Количество секунд прошедших с получения последней DGPS поправки (SC104)
            message.Append("1,");
            // 14 - ID базовой станции предоставляющей DGPS поправки (если включено DGPS)
            message.Append("0001,");
            // Контрольная сумма (в примере просто число, т.к. она не проверяется) + перенос строки
            message.Append("*FF\r\n");

            return message.ToString();
        }

        /// <summary>
        /// Конвертация градусов в формат "ГГММ.МММММ" или "ГГГММ.МММММ"
        /// </summary>
        /// <param name="ValueToConvert">Значение в формате "ГГ.ГГГГГГГ"</param>
        /// <param name="isLongtitude">Передаётся ли долгота, или широта
        /// <para><b>true</b> - выходной формат данных "ГГГММ.МММММ"</para>
        /// <para><b>false</b> - выходной формат данных "ГГММ.МММММ"</para></param>
        /// <returns></returns>
        private static string ConvertDoubleToFormatNMEA(double ValueToConvert, bool isLongtitude)
        {
            double mainPart = Math.Floor(ValueToConvert);
            double numberNMEA = mainPart * 100 + (ValueToConvert - mainPart) * 60;
            string output = isLongtitude ? String.Format(new System.Globalization.CultureInfo("en-US"), "{0:00000.00000}", numberNMEA) :
                String.Format(new System.Globalization.CultureInfo("en-US"), "{0:0000.00000}", numberNMEA);
            return output;
        }

        /// <summary>
        /// Прочитать последнее сообщение формата NMEA из файла и извлечь оттуда координаты, приведя их к виду "ГГ.ГГГГГГГ"/"ГГГ.ГГГГГГ"
        /// </summary>
        /// <returns></returns>
        public static Coordinate DecodeLastData()
        {
            var lines = File.ReadAllLines(FullFileName);

            if (lines.Length < 2) return new Coordinate();

            string lastMessage = lines[lines.Length - 2];
            string[] messageParts = lastMessage.Split(',');
            string lat = messageParts[2];
            string lng = messageParts[4];
            double latitude = DecodeCoordinate(lat);
            double longtitude = DecodeCoordinate(lng);

            return new Coordinate(latitude, longtitude);
        }

        /// <summary>
        /// Декодировать значение координаты из формата "ГГММ.МММММ" в формат "ГГГГ.ГГГГГ"
        /// </summary>
        /// <param name="EncodedValue">Закодированное значение координат</param>
        /// <returns></returns>
        private static double DecodeCoordinate(string EncodedValue)
        {
            double encodedValue = Double.Parse(EncodedValue, CultureInfo.InvariantCulture);
            double minutes = encodedValue % 100;
            double gradus = (encodedValue - minutes) / 100;
            minutes /= 60;
            double decodedValue = gradus + minutes;

            return decodedValue;
        }

        private static string GetFullFileName()
        {
            string solutiondir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            solutiondir += "\\" + FileName;
            return solutiondir;
        }
    }
}
