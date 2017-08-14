namespace VehicleShop.Core.IO
{
    using System;
    using VehicleShop.Interfaces.IO;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}