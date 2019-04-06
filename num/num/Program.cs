using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] X = new int[10];
            System.Console.WriteLine("please enter 10 integer");
            int big = 0;
            for (int i = 0; i < 10; i++)
            {
                X[i] = int.Parse(System.Console.ReadLine());
                if (big < X[i])
                {
                    big = X[i];
                }
            } //end for

            System.Console.WriteLine("big is:" + big);
            Console.ReadKey();

        }
    }
}
