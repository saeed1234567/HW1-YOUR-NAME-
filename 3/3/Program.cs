using HW_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    public class adad
    {
        public string methood(int[] X, int size)
        {
            int[] XX = new int[10];
            for (int i = 0; i < size; i++)
            {
                X[i] = XX[i];
            }
            System.Console.WriteLine("please enter 10 integer");
            int big = 0;
            for (int i = 0; i < size; i++)
            {
                X[i] = int.Parse(System.Console.ReadLine());
                if (big < X[i])
                {
                    big = X[i];
                }
            } //end for
            return big.ToString();

        }



    }

    public class tarikh
    {
        public string a;
        public string methoood()
        {


            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

            a = (pc.GetYear(DateTime.Now) + "/" + pc.GetMonth(DateTime.Now) + "/" + pc.GetDayOfMonth(DateTime.Now));
            return a;

        }
    }



}


class Program
{
    static void Main(string[] args)
    {
        adad ob1 = new adad();
        //Console.WriteLine(ob1);
        int[] m = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(ob1.methood(m, 10));
        tarikh ob2 = new tarikh();
        Console.WriteLine(ob2.methoood());
        Console.ReadKey();


    }


}

