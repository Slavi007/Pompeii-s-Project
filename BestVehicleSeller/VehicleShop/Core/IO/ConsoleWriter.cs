namespace VehicleShop.Core.IO
{
    using System;
    using VehicleShop.Interfaces.IO;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string content)
        {
            Console.WriteLine(content);
        }
    }
}