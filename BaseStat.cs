using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{

    

        public static class Program
        {
            
            private static double Aggregate(  double [] p , double init,Func<double,double,double> fn) {
                              
                double temp = init;
                foreach (var n in p)
                   temp =  fn(n,temp);
                return temp;

            }
            private static double AMEAN(double[] p)
            {
                return Aggregate(p, 0, (double a, double b) => 
                     { return b += a; }) / p.Length;
            }

            private static double GMEAN(double[] p)
            {
                double pi = Aggregate(p, 1, 
                    (double a, double accum) => { return accum *= a; });
                return Math.Exp(Math.Log(pi)*(1 / p.Length));
                
            }

            private static double STD(double[] p)
            {
                double avg = Aggregate(p, 0,(double a, double b) => { return b += a; }) / p.Length;
                double var = Aggregate(p, 0, (double a, double b) => { return b += ((a - avg)*(a-avg)); }) / p.Length;
                return Math.Sqrt(var);
            }
            static void Main(string[] args)
            {
                double[] arr = { 2, 4, 4, 4 ,5,5,7,9};
                List<double> arrlist = arr.ToList();
                double nsum = 0;
                foreach (var n in arr)
                    nsum += n;
                double avg = nsum / arrlist.Count;
                Console.WriteLine(avg);
                Func<double, double, double> fn = (double a, double sum) =>
                {
                    return ( sum += a);
                };
                double result = Aggregate(arr,0,
                     (double a, double accum) => { return accum +=a; });
                 Console.WriteLine(result);
                 double [] arr2 = { 4, 1, 1 / 32.0 };
                 result = GMEAN(arr2);
                 Console.WriteLine(result);
                 result = STD(arr);
                 Console.WriteLine(result);
                 Console.Read();
            }
        }
    }
