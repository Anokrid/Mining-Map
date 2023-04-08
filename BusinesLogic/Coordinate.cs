namespace BusinesLogic
{
    /// <summary>
    /// Структура, описывающая координаты объекта
    /// </summary>
    public struct Coordinate
    {
        /// <summary>
        /// Широта
        /// </summary>
        public double Latitude;

        /// <summary>
        /// Долгота
        /// </summary>
        public double Longtitude;

        /// <summary>
        /// Конструктор координаты какого-либо объекта
        /// </summary>
        /// <param name="Latitude">Значение широты</param>
        /// <param name="Longtitude">Значение долготы</param>
        public Coordinate(double Latitude, double Longtitude)
        {
            this.Latitude = Latitude;
            this.Longtitude = Longtitude;
        }
    }
}
