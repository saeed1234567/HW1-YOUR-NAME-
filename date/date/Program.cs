using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarikh
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

            Console.WriteLine((pc.GetYear(DateTime.Now) + "/" + pc.GetMonth(DateTime.Now) + "/" + pc.GetDayOfMonth(DateTime.Now)));
            Console.ReadKey();
        }
    }
}
