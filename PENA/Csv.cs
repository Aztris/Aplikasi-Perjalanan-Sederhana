using CsvHelper;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENA
{
    public class Csv
    {
        static Csv() {
            Directory.CreateDirectory(Program.EXE_DIR + "\\data");
        }

        public static List<T> readCsv<T>(String name)
        {
            var filePath = Program.EXE_DIR + "\\data\\" + name;
            Console.WriteLine(filePath);

            if (!File.Exists(filePath))
            {
                return new List<T>();
            }

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<T>().ToList();
            }
        }

        public static void writeCsv<T>(String name, List<T> data)
        {
            var filePath = Program.EXE_DIR + "\\data\\" + name;
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(data);
            }
        }
    }
}
