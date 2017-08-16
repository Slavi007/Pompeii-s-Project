namespace VehicleShop.Core
{
    using System.Collections.Generic;
    using VehicleShop.Core.IO;

    public class Utilities
    {
        public IDictionary<string, decimal> GetExtrasByBrand(string brand)
        {
            FileReader reader = new FileReader($"{brand}.txt");
            return reader.ReadExtrasFile($"{brand}.txt");
        }



    }
}