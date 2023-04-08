namespace BusinesLogic
{
    /// <summary>
    /// Запись об определённой единице техники
    /// </summary>
    public class TechnicRecord
    {
        #region Публичные свойства
        /// <summary>
        /// ID записи
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Тип техники
        /// </summary>
        public string TechicType { get; private set; }

        /// <summary>
        /// Расположение техники (её текущие координаты)
        /// </summary>
        public Coordinate Position { get; set; }

        /// <summary>
        /// Цвет маркера, отображающего данную единицу техники на карте
        /// </summary>
        public Color MarkerColor { get; set; }
        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор записи о технике, хранящейся в базе данных
        /// </summary>
        /// <param name="Id">Идентификационный номер техники</param>
        /// <param name="TechicType">Тип техники</param>
        /// <param name="Position">Географические координаты техники</param>
        /// <param name="MarkerColor">Цвет маркера на карте</param>
        public TechnicRecord(int Id, string TechicType, Coordinate Position, Color MarkerColor = Color.Red)
        {
            this.Id = Id;
            this.TechicType = TechicType;
            this.Position = Position;
            this.MarkerColor = MarkerColor;
        }

        #endregion
    }
}
