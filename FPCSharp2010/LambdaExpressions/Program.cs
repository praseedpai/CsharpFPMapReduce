using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpressions
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="init"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        static IEnumerable<T> Generator<T>(T init, Func<T, T> next)
        {
            T current = init;

            while (true)
            {

                yield return current;
                current = next(current);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Func<double, double> square = (double a) => a * a;
            Func<double, double> doubler = (a) => a + a;

            Console.WriteLine(doubler(square(5)));
            IEnumerable<double> skipper = Generator<double>(0, (a) => a + 2);

            foreach (double skip in skipper)
            {

                if (skip > 50)
                    break;

                Console.WriteLine(skip);
            }
            Console.Read(); 
        }
    }
}
