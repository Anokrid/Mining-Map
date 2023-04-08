using System;

namespace BusinesLogic
{
    /// <summary>
    /// Генератор случайных чисел <see cref="double"/>
    /// </summary>
    public static class RandomDoubleGenerator
    {
        private static Random _random;

        static RandomDoubleGenerator()
        {
            _random = new Random();
        }

        /// <summary>
        /// Получить случайное число типа <see cref="double"/> в диапазоне
        /// </summary>
        /// <param name="minimum">Минимальное значение числа</param>
        /// <param name="maximum">Максимальное число</param>
        /// <returns></returns>
        public static double GetRandomNumber(double minimum, double maximum)
        {
            return _random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
