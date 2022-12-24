namespace BasicFunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select program\n 1.PowerOf2");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PowerOf2 powerOf2  = new PowerOf2();
                    powerOf2.Read();
                    break;
            }
        }
    }
}