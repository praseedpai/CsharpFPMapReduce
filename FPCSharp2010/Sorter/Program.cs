using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorter
{
    class Program
    {
        /// <summary>
        ///   A naive bubble sorter...
        /// </summary>
        /// <param name="ars"></param>
        /// <param name="comp"></param>
        /// <returns></returns>
        public static bool BubbleSort(double[] ars, Func<double, double, bool> comp)
        {

            int length = ars.Length;
            for( int i=0; i < length; ++i )
                for(int j=0;j<length; ++j )
                    if (comp(ars[i], ars[j]))
                    {
                        double temp = ars[i];
                        ars[i] = ars[j];
                        ars[j] = temp;

                    }

            return true;
        }

        static void Main(string[] args)
        {
            double[] ars = { 10, 1, 2 };
            /////////////////
            // Sort in Ascending Order...
            //
            BubbleSort(ars, (a, b) => a > b ? false : true);
            foreach (double a in ars)
                Console.WriteLine(a);

            ////////////////////////////////
            // Sort in Descending order...
            //
            //
            BubbleSort(ars, (a, b) => a > b ? true : false);
            foreach (double a in ars)
                Console.WriteLine(a);
            Console.Read();

        }
    }
}
