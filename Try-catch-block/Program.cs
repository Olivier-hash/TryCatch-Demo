using System;

namespace ProjectName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte trage eine Zahl ein");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (Exception) // alt: FormatException, ArgumentNullException, OverflowException
            {
                Console.WriteLine("Fehrer aufgetreten! z.b eingegeben wort wer war falsch");
            }

            Console.ReadLine();
            
        }
       
    }
}
