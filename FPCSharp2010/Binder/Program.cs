using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binder
{
    /// <summary>
    /// 
    /// </summary>
    public static class Currying
    {
        public static Func<U, V> Bind1st<T, U, V>(this Func<T, U, V> func,
                                                 T constant)
        {

            return (x) => func(constant, x);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="func"></param>
        /// <param name="constant"></param>
        /// <returns></returns>
        public static Func<T, V> Bind2nd<T, U, V>(this Func<T, U, V> func,
                                               U constant)
        {

            return (x) => func(x,constant);
        }

    }
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Func<double,double,double> func = ( x, y) => x +y;
            Console.WriteLine(func.Bind1st(10)(3));
            Console.WriteLine(func.Bind2nd(3)(10));
            Console.Read();

        }
    }
}
