using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PENA
{
    public static class Program
    {
        public static readonly string EXE_PATH = Assembly.GetExecutingAssembly().Location;
        public static readonly string EXE_DIR = Directory.GetParent(EXE_PATH).FullName;

        public static readonly List<UserModel> Users = Csv.readCsv<UserModel>("config.csv");
        public static readonly List<TripModel> Trips = Csv.readCsv<TripModel>("trips.csv");
        public static UserModel user=null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dashboardForm());
        }

        public static void SaveCsvs()
        {
            Csv.writeCsv("config.csv", Users);
            Csv.writeCsv("trips.csv", Trips);
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            SaveCsvs();
        }
    }
}
