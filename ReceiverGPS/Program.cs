using BusinesLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiverGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync();
            Console.ReadLine();
        }

        static async Task MainAsync()
        {
            Console.WriteLine("Техника с id = 1 начала движение:");
            Coordinate initialCoordinates = new Coordinate(66.42, 94.25);
            var emulator = new MachinaryEmulator(initialCoordinates);
            await Task.Run(() => emulator.StartEmulation()); 
        }
    }
}
