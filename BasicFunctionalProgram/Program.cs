namespace BasicFunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select program\n 1VowelConsonant");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    VowelConsonant vowelConsonant = new VowelConsonant();
                    vowelConsonant.Alphabet();
                    break;
            }
        }
    }
}