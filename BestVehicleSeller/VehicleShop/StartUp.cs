namespace VehicleShop
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net.Http;
    using VehicleShop.Core.IO;
    using VehicleShop.Interfaces.IO;

    public class StartUp
    {
        public static void Main()
        {
            FileReader reader = new FileReader("Ford.txt");

            IDictionary<string, decimal> dict = new Dictionary<string,decimal>();

            dict = reader.ReadExtrasFile("Ford.txt");

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} have price {item.Value}");
            }
        }
    }
}
