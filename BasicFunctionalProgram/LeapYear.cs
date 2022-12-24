using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalProgram
{
    internal class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("Enter four digit number year :");
            int year =Convert.ToInt32(Console.ReadLine());
            if (year % 100 == 0 && year % 400 == 0)
            {
                Console.WriteLine("It is a leap year", year);
                return;
            }
            if (year % 100 != 0 && year % 4 == 0)
                Console.WriteLine("It is a leap year", year);
            else
                Console.WriteLine("It is not a leap year", year);
        }
    }
}
    

