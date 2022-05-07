using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class System
    {
       static int i = 0; 

        public static void Interface ()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("      welcome to our StopWatch   ");
            Console.WriteLine("      ************************    ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("press 1 to start");
            Console.WriteLine("press 2 to stop");
            Console.WriteLine("press 3 to display the duration");
            Console.WriteLine("note : you can't press the the strat twice ");

        }

        public static void Implement()
        {
            while (true)
            {
                if (i == 0)
                {
                    i = int.Parse(Console.ReadLine());
                    if (!(i == 1))
                    { Console.WriteLine("Invalid input.Try Again");
                        i = 0;
                    }
                    else
                        StopWatch.Start();

                }

                if (i == 1)
                {
                    i = int.Parse(Console.ReadLine());
                    if (!(i == 2))
                    {
                        Console.WriteLine("Invalid input .Try Again");
                        i = 1;
                    }
                    else
                        StopWatch.Stop();

                }

                if (i == 2)
                {
                    i = int.Parse(Console.ReadLine());
                    if (!(i == 3 || i == 1))
                    {
                        Console.WriteLine("Invalid input .Try Again");
                        i = 2;
                    }
                    else if (i == 3)
                    {
                        StopWatch.Duration();
                        i = 0;
                    }
                    else if (i == 1)
                        StopWatch.Start();
                }

            }
        }
        

    }
}
