using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Third
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<double> t = new List<double> { 2, 3, 5 };
           
            List<double> gt2 = t.FindAll((a) => a > 2);
            foreach (double s in gt2)
                Console.WriteLine(s);

            Console.Read();


        }
    }
}
