namespace BasicFunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select program\n 1.flip coin");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoins flipCoins = new FlipCoins();
                    flipCoins.Coin();
                    break;
            }
        }
    }
}