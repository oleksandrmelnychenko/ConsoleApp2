using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;

            StreamReader reader = new StreamReader(File.OpenRead(@"D:\CarData\tz_opendata_z01012017_po31122017.csv"), Encoding.UTF8);
            List<Model> models = new List<Model>();

            CSVParser cSVParser = new CSVParser();
            List<string> jObjects = cSVParser.ParseToJson(reader);

            foreach (string jItem in jObjects) {
                models.Add(JsonConvert.DeserializeObject<Model>(jItem));
            }

            Console.ReadLine();
        }
    }

    public class CSVParser {

        public List<string> ParseToJson(StreamReader sourceStreamReader) {
            string modelPattern = BuildCSVModelPatern(sourceStreamReader.ReadLine());

            List<string> output = new List<string>();

            string singleLineWorker = "";
            string[] csvValues = null;

            int counter = 0;

            while (!sourceStreamReader.EndOfStream) {
                Console.WriteLine(counter);

                singleLineWorker = sourceStreamReader.ReadLine();
                singleLineWorker = singleLineWorker.Replace("\"", "");
                singleLineWorker = singleLineWorker.Replace("\\","/");

                csvValues = singleLineWorker.Split(';');
                for (int i = 0; i < csvValues.Length - 1; i++) {
                    csvValues[i] = (csvValues[i] == "null" || csvValues[i] == "NULL") ? null : csvValues[i];
                }

                output.Add(BuildJSONFromCSVValues(csvValues, modelPattern));

                counter++;
            }

            return output;
        }

        private string BuildJSONFromCSVValues(IEnumerable<string> csvValues, string modelPattern) {
            string outputJSONObject = string.Format(modelPattern, csvValues.ToArray());

            return outputJSONObject;
        }

        private string BuildCSVModelPatern(string csvModelLine) {
            string[] properties = csvModelLine.Split(';');

            string modelPattern = "";

            modelPattern += "{{";

            for (int i = 0; i < properties.Length; i++) {
                modelPattern += string.Format("\"{0}\":", properties[i]);
                modelPattern += string.Format("\"{{{0}}}\",", i);
            }

            modelPattern = modelPattern.Remove(modelPattern.Length - 1, 1);

            modelPattern += "}}";

            return modelPattern;
        }
    }

    public class Model {
        [JsonProperty("person")]
        public string Person { get; set; }

        [JsonProperty("reg_addr_koatuu")]
        public string RegAddrKoatuu { get; set; }

        [JsonProperty("oper_code")]
        public string OperCode { get; set; }

        [JsonProperty("oper_name")]
        public string OperName { get; set; }

        [JsonProperty("d_reg")]
        public string DReg { get; set; }

        [JsonProperty("dep_code")]
        public string DepCode { get; set; }

        [JsonProperty("dep")]
        public string Dep { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("model")]
        public string ModelName { get; set; }

        [JsonProperty("make_year")]
        public string MakeYear { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("fuel")]
        public string Fuel { get; set; }

        [JsonProperty("capacity")]
        public string Capacity { get; set; }

        [JsonProperty("own_weight")]
        public string OwnWeight { get; set; }

        [JsonProperty("total_weight")]
        public string TotalWeight { get; set; }

        [JsonProperty("n_reg_new")]
        public string NRegNew { get; set; }
    }
}
