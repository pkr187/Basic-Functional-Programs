namespace BasicFunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select program\n 1.SwapNumber");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    SwapNumber swapNumbers = new SwapNumber();
                    swapNumbers.Swap();
                    break;
            }
        }
    }
}