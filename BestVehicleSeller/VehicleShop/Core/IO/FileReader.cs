namespace VehicleShop.Core.IO
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.IO;
    using VehicleShop.Interfaces.IO;

    public class FileReader : IReader
    {
        public FileReader(string folder, string fileName) : this(fileName)
        {
            this.PathToFolder = $@"..\..\..\{folder}\";
        }

        public FileReader(string fileName)
        {
            this.PathToFolder = @"..\..\Resources.Extras\";
            this.FileName = fileName;

        }

        public string ReadLine()
        {
            return null;
        }

        public IDictionary<string, decimal> ReadExtrasFile(string fileName)
        {
            string path = Path.Combine(PathToFolder, FileName);
            IDictionary<string, decimal> dict = new Dictionary<string, decimal>();

            using (StreamReader reader = new StreamReader(path))
            {
                string inputLine = String.Empty;

                while ((inputLine = reader.ReadLine()) != null)
                {
                    string[] args = inputLine.Split(new char[] { ';' }, StringSplitOptions.None);
                    dict.Add(args[0], decimal.Parse(args[1]));
                }

            }
            return dict;
        }


        public string PathToFolder { get; set; }
        public string FileName { get; set; }
    }
}