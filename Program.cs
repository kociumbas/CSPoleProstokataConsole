using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1poleProstokataConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, pole = 0;
            Console.WriteLine("Program oblicza pole prostokata o bokach a i b");
            Console.Write("Podaj długość boku a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj długość boku b = ");
            b = Convert.ToDouble(Console.ReadLine());
            pole = a * b;
            Console.Write("Pole prostokata o bokach a = {0} i b = {1}", a, b);
            Console.WriteLine(" wynosi {0}", pole);
            Console.ReadLine();
        }
    }
}
