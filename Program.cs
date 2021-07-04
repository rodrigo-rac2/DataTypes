using System;
using System.Collections.Generic;
using System.IO;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            int _i;
            double _d;
            string _s;

            _i = int.Parse(Console.ReadLine());
            _d = double.Parse(Console.ReadLine());
            _s = Console.ReadLine();

            Console.WriteLine(i + _i);
            Console.WriteLine(string.Format("{0:N1}", d + _d)); // Trunc(d + _d, 1));
            // Console.WriteLine(string.Format("{0:0.0}", Math.Truncate(((d + _d) * 10) / 10)));
            Console.WriteLine(s + _s);
        }

        static double Trunc(double value, int digits)
        {
            double mult = System.Math.Pow(10.0, digits);
            return System.Math.Truncate(value * mult) / mult;
        }
    }
}
