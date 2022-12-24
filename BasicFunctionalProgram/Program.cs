namespace BasicFunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select program\n 1.HarmonicNumber");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    HarmonicNumber harmonicNumber  = new HarmonicNumber();
                    harmonicNumber.Number();
                    break;
            }
        }
    }
}