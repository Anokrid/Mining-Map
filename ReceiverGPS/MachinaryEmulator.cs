using BusinesLogic;
using System;
using System.Threading.Tasks;

namespace ReceiverGPS
{
    /// <summary>
    /// Симулятор единицы техники
    /// </summary>
    public class MachinaryEmulator
    {
        /// <summary>
        /// Текущая позиция техники
        /// </summary>
        private Coordinate _position;

        /// <summary>
        /// Назначение, позиция, куда техника должна переместиться
        /// </summary>
        private Coordinate _destination;

        /// <summary>
        /// Радиус, на величину которого может измениться точка назначения техники от её текущих координат
        /// </summary>
        private double _readius = 5;

        /// <summary>
        /// Расстояние, которое техника преодолевает за 1 секунду
        /// </summary>
        private double _step = 0.1;

        /// <summary>
        /// Достигла ли техника своего пункта назначения
        /// </summary>
        private bool _destinationIsReached => _position.Latitude ==_destination.Latitude && _position.Longtitude == _destination.Longtitude;

        public MachinaryEmulator(Coordinate InitialCoordinates)
        {
            _position = InitialCoordinates;
            _destination = _position;
        }

        /// <summary>
        /// Запуск эмуляции передвижения техники
        /// </summary>
        /// <returns></returns>
        public async Task StartEmulation()
        {
            while (true)
            {
                await Task.Delay(1000);
                if (_destinationIsReached)
                {
                    Console.WriteLine("Транспорт достиг своей цели!");
                    UpdateDestination();
                    Console.WriteLine("Новая точка назначения: {0} : {1}", _destination.Latitude, _destination.Longtitude);
                }
                else
                {
                    MoveToDestination();
                    Console.WriteLine("Транспорт в пути: {0} : {1}", _position.Latitude, _position.Longtitude);
                }

                ParserGPS.EncodeData(_position);
            }
        }

        /// <summary>
        /// Обновить точку назначения техники
        /// </summary>
        private void UpdateDestination()
        {
            double newDestinationLatitude = RandomDoubleGenerator.GetRandomNumber(
                        _position.Latitude - _readius, _position.Latitude + _readius);
            double newDestinationLongtitude = RandomDoubleGenerator.GetRandomNumber(
                _position.Longtitude - _readius, _position.Longtitude + _readius);
            _destination = new Coordinate(newDestinationLatitude, newDestinationLongtitude);
        }

        /// <summary>
        /// Передвигаться к цели назначения
        /// </summary>
        private void MoveToDestination()
        {
            TryMoveForward(ref _position.Latitude, _destination.Latitude);
            TryMoveBackward(ref _position.Latitude, _destination.Latitude);

            TryMoveForward(ref _position.Longtitude, _destination.Longtitude);
            TryMoveBackward(ref _position.Longtitude, _destination.Longtitude);
        }

        /// <summary>
        /// Попытаться двигаться вперёд (если цель расположена дальше, чем текущая позиция)
        /// </summary>
        /// <param name="position"></param>
        /// <param name="destination"></param>
        private void TryMoveForward(ref double position, double destination)
        {
            if (position < destination)
            {
                position += _step;
                if (position > destination)
                {
                    position = destination;
                }
            }
        }

        /// <summary>
        /// Попытаться двигаться назад, если цель расположена ближе, чем текущая позиция)
        /// </summary>
        /// <param name="position"></param>
        /// <param name="destination"></param>
        private void TryMoveBackward(ref double position, double destination)
        {
            if (position > destination)
            {
                position -= _step;
                if (position < destination)
                {
                    position = destination;
                }
            }
        }
    }
}
