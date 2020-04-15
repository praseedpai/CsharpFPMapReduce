using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda
{
    class Program
    {
        /// <summary>
        ///   A Lambda expression which gives the value of PI
        /// </summary>
        /// <returns></returns>
        public static Func<double> PI()
        {
            return () => { return 3.14159; };

        }
        /// <summary>
        ///   A function which returns lambda 
        /// </summary>
        /// <returns></returns>
        public static Func<dynamic, dynamic, dynamic> Adder()
        {
            return (dynamic a, dynamic b) => { return a + b; };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(Adder()("Hello ", "World"));
            Console.WriteLine(Adder()(10, 20));
            Console.WriteLine(PI()());
            Console.Read();
        }
    }
}
