namespace BasicFunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select program\n 1.OddEvenNumber");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    OddEvenNumber oddEvenNumber = new OddEvenNumber();
                    oddEvenNumber.Read();
                    break;
            }
        }
    }
}