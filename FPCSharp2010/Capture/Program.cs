using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capture
{
    class Program
    {

        static void Main(string[] args)
        {
            // First build a list of actions
            List<Action> actions = new List<Action>();
#if true
           // int cpt;
#endif

            for (int counter = 0; counter < 10; counter++)
            {
//#if true 
  //               int 
//#endif
              int   cpt = counter;
                actions.Add(() => Console.WriteLine(cpt));
            }

            // Then execute them
            foreach (Action action in actions)
            {
                action();
            }
            Console.Read();

        }
    }
}
