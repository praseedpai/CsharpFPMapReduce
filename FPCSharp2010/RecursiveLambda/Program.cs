using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursiveLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code 3
            // Generic lambda expression usage
            // declare a parameterized type XPowerN
            Func<int, float, float> XPowerN = null;

            // definition
            XPowerN = (n, x) =>
            {
                if (n == 0) return 1.0f;
                else return x * XPowerN(n - 1, x);
            };

            // using XPowerN in Square & Cube methods
            Func<float, float> Square = x => XPowerN(2, x);
            Func<float, float> Cube = x => XPowerN(3, x);

            Console.WriteLine(Square(5.0f).ToString());
            Console.WriteLine(Cube(5.0f).ToString());
            Console.Read();
        }
    }
}
