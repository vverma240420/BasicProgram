using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Weekday
    {
        public static void FindADayWhichFallsOnWeek(int dayNumber)
        {
            switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("It's Sunday");
                    break;

                case 2:
                    Console.WriteLine("It's Monday");
                    break;

                  case 3:
                    Console.WriteLine("It's Tuesday");
                    break;

                case 4:
                    Console.WriteLine("It's Wedenesday");
                    break;

                case 5:
                    Console.WriteLine("It's Thursday");
                    break;

                case 6:
                    Console.WriteLine("It's Friday");
                    break;

                case 7:
                    Console.WriteLine("It's Saturday");
                    break;

                default:
                    Console.WriteLine("Please choose a number between 1 to 7");
                    break;
            }
        }
    }
}
