using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Second
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Func<double, double> Doubler()
        {
            int i = 1;
            return (double a) => a * a*i++;

        }

        static void Main(string[] args)
        {
            Func<double, double> dt = Doubler();
            Console.WriteLine(dt(2));
            Console.WriteLine(dt(2));
            Console.WriteLine(dt(2));
            Console.Read();

        }
    }
}
