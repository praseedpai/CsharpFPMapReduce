using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Curry
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ///
            // A Lamda Expression which takes two doubles as parameter
            //
            Func<double, double, double> adder = (a, b) => a + b;
            //
            // Define a function add10 ... which reduces the arity 
            // This is an example of currying ....where a 2 arity
            // function got reduced to a one arity...
            Func<double, double> add10 = (c ) => adder(c,10);
            ///
            /// Successor function....
            ///
            Func<double, double> succ = (c) => adder(c, 1);
            //
            // Predecessor function....
            //
            Func<double, double> pred = (c) => adder(c, -1);
            ///
            ///
            /// Mul function defined in term of addition....
            /// 
            Func<double, double, double> mul = null;
            mul = (a, b) => b == 0 ? 0 : adder(mul(a, b - 1), a);
            Func<double, double,double> mulcopy = mul;
            Console.WriteLine(mulcopy(6.0,2.0));                        // displays 8
            Console.WriteLine(mul(6,2));                    // displays 8
            mul =( n , c ) => n * 2;
            Console.WriteLine(mulcopy(6,2));                        // displays 12
            Console.WriteLine(mul(6,2));                    // displays 18



            //
            // Invoke the arity reduced function... 
            //
          //  Console.WriteLine(add10(30));
          //  Console.WriteLine(succ(10));
           // Console.WriteLine(pred(21));
          //  Console.WriteLine(mul(17, 17));
            Console.Read();



        }
    }
}
