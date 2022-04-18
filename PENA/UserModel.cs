using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENA
{
    public class UserModel
    {
        public long nik { get; set; }
        public string name { get; set; }   
        public string image { get; set; }
    }

    public class TripModel
    {
        public long nik { get; set; }
 
        public string date { get; set; }
        public string time { get; set; }
        public string location { get; set; }
        public double bodyTemp { get; set; }

        public DateTime GetTime()
        {
            return DateTime.ParseExact(time, "HH.mm", null);
        }

        public DateTime GetDate()
        {
            return DateTime.ParseExact(date, "dd-MM-yyyy", null);
        }
    }
}
