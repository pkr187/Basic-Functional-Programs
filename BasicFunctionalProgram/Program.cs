namespace BasicFunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select program\n 1.LeapYear");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LeapYear leapYear  = new LeapYear();
                    leapYear.Year();
                    break;
            }
        }
    }
}