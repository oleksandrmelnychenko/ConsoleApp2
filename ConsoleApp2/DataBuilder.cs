using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    public class DataBuilder
    {
        public static List<Model> GetData()
        {
            StreamReader reader = new StreamReader(File.OpenRead(@"D:\CarData\tz_opendata_z01012017_po31122017.csv"), Encoding.UTF8);
            List<Model> models = new List<Model>();

            CSVParser cSVParser = new CSVParser();
            List<string> jObjects = cSVParser.ParseToJson(reader);

            foreach (string jItem in jObjects)
            {
                models.Add(JsonConvert.DeserializeObject<Model>(jItem));
            }

            return models;
        }
    }
}
