using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // read file into a string and deserialize JSON to a type
            var MDAListFile = JsonConvert.DeserializeObject<List<MDAListItem>>(File.ReadAllText(@"C:\Users\lbello2\Desktop\mdaList.txt").Replace("MDAList:",string.Empty));

            // write the file to csv
            using (var writer = new StreamWriter(@"C:\Users\lbello2\Desktop\convertedfile.csv", true))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(MDAListFile);
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
