using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfiniteList
{
    static class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static IEnumerable<int> InfiniteList()
        {
            int n = 0;

            while (true)
            {

                yield return (n+=2);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <param name="input"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static IEnumerable<R> Transform<T, R>(
            this IEnumerable<T> input, Func<T, R> func)
        {

            foreach (var item in input)
                yield return func(item);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var s  = InfiniteList() ;
            var n = s.Transform(x => x * 2).Transform(x=> x/2 );
            foreach (var l in n)
            {
                if (l > 100)
                    break;

                Console.WriteLine(l);
            }

            Console.Read();

        }
    }
}
