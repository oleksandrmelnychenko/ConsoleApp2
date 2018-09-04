using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace car.id.server.Helpers
{
    public class CSVParser
    {
        public List<string> ParseToJson(StreamReader sourceStreamReader)
        {
            string modelPattern = BuildCSVModelPatern(sourceStreamReader.ReadLine());

            List<string> output = new List<string>();

            string singleLineWorker = "";
            string[] csvValues = null;

            int counter = 0;

            while (!sourceStreamReader.EndOfStream)
            {
                Console.WriteLine(counter);

                singleLineWorker = sourceStreamReader.ReadLine();
                singleLineWorker = singleLineWorker.Replace("\"", "");
                singleLineWorker = singleLineWorker.Replace("\\", "/");

                csvValues = singleLineWorker.Split(';');
                for (int i = 0; i < csvValues.Length - 1; i++)
                {
                    csvValues[i] = (csvValues[i] == "null" || csvValues[i] == "NULL") ? null : csvValues[i];
                }

                output.Add(BuildJSONFromCSVValues(csvValues, modelPattern));

                counter++;
            }

            return output;
        }

        private string BuildJSONFromCSVValues(IEnumerable<string> csvValues, string modelPattern)
        {
            string outputJSONObject = string.Format(modelPattern, csvValues.ToArray());

            return outputJSONObject;
        }

        private string BuildCSVModelPatern(string csvModelLine)
        {
            string[] properties = csvModelLine.Split(';');

            string modelPattern = "";

            modelPattern += "{{";

            for (int i = 0; i < properties.Length; i++)
            {
                modelPattern += string.Format("\"{0}\":", properties[i]);
                modelPattern += string.Format("\"{{{0}}}\",", i);
            }

            modelPattern = modelPattern.Remove(modelPattern.Length - 1, 1);

            modelPattern += "}}";

            return modelPattern;
        }
    }
}
