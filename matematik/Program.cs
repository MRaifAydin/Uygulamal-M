using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematik
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("m değerini girin");
            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("M değerini girin");
            double second = double.Parse(Console.ReadLine());

            double f = first - second;

            double x = Math.Round(Math.Pow(10, (f + 5) / 5));

            Console.WriteLine(x);

            Console.ReadLine();

        }
    }
}
