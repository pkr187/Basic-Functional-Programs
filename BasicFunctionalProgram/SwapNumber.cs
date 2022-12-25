using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalProgram
{
    internal class SwapNumber
    {
        public void Swap()
        {
            int number1, number2, temp;
            Console.Write("Enter the First number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            number2 =Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("After swapping");
            Console.Write("\nFirst number: " + number1);
            Console.Write("\nSecond number: " + number2);
        }
    }
}


