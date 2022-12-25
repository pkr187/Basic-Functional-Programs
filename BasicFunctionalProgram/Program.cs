namespace BasicFunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select program\n 1.QuotientRemainder");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    QuotientRemainder quotientRemainder = new QuotientRemainder();
                    quotientRemainder.QuoRem();
                    break;
            }
        }
    }
}