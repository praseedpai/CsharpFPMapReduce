using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapReduce
{
   
        class Program
        {
            /// <summary>
            /// 
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="x"></param>
            /// <param name="f"></param>
            /// <param name="init"></param>
            /// <returns></returns>
            public static T Agg<T>(IEnumerable<T> x, Func<T, T, T> f, T init)
            {
                T s = init;
                foreach (T t in x)
                {
                    s = f(s, t);

                }

                return s;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="x"></param>
            /// <param name="f"></param>
            /// <returns></returns>
            public static IEnumerable<T> Map<T>(IEnumerable<T> x, Func<T, T> f)
            {
                List<T> n = new List<T>();

                foreach (T t in x)
                {
                    n.Add(f(t));

                }

                return n;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="x"></param>
            /// <param name="f"></param>
            /// <param name="init"></param>
            /// <returns></returns>
            public static T Reduce<T>(IEnumerable<T> x, Func<T, T, T> f, T init)
            {
                T s = init;
                foreach (T t in x)
                {
                    s = f(s, t);

                }

                return s;

            }
            /// <summary>
            /// 
            /// </summary>
            public static void Adder()
            {
                Func<double, double, double> adder = (x, y) => x + y;

                double[] arr = { 10, 20, 30 };
                double n = Agg<double>(arr, adder, 0);
                Console.WriteLine(n);



            }

            public static void Greatest()
            {
                Func<double, double, double> comparer = (x, y) => { return (x > y) ? x : y; };
                double[] arr = { 10, 20, 30 };
                double n = Agg<double>(arr, comparer, -100);
                Console.WriteLine(n);

            }

            public static void MapReduce()
            {
                Func<double, double, double> adder = (x, y) => x + y;

                double[] arr = { 10, 20, 30 };
                IEnumerable<double> mapped = Map<double>(arr, (x) => x * x);
                double n = Reduce<double>(mapped, adder, 0);
                Console.WriteLine(n);


            }




            static void Main(string[] args)
            {
                Adder();
                Greatest();
                MapReduce();
                Console.ReadLine();
            }
        }
    }

