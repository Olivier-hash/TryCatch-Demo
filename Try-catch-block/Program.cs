using System;

namespace ProjectName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte trage eine Zahl ein");
            string userInput = Console.ReadLine();

            // Addition code to divide userinput by zero
            try
            {
                int userInputAsInt = int.Parse(userInput);
                int result = userInputAsInt / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Durch 0 teilen ist nicht erlaubt");
            }

            try
            {
                
                int userInputAsInt = int.Parse(userInput);
            }
            // alt: FormatException, ArgumentNullException, OverflowException, Exception ex

            catch (FormatException)
            {
                Console.WriteLine("format war inkorrekt: Du hattest eine Nummer eintragen sollen ");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("ArgumentException: der welt war leer(null");
            }
            catch(OverflowException)
            {
                Console.WriteLine("OverflowException, der eingegeben wert, war zu lang");
            }
            catch (Exception) 
            {
                Console.WriteLine("Fehrer aufgetreten! z.b eingegeben wort wer war falsch");
            }
            finally
            {
                // verbindnund schließen, oder Datei Schließen
                Console.WriteLine("ich werde sowieso ausgeführt");
            }



            Console.ReadLine();
            //comd
            
        }
       
    }
}
