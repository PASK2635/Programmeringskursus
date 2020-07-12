using System;

namespace StatementsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();

            if(sentence[0] == 'a') //Hvis <condition> er korrekt (true), 
            { //Udfør koden der er i næste "scope" (tuborg-klammer {})
                Console.WriteLine("Det første bogstav var a!");
            }

            /*
                Her er de forskellige "Conditional Operators".
                ==  -> is equal to
                !=  -> is not equal to
                <   -> less than
                >   -> greater than
                <=  -> less than or equal to
                >=  -> greater than or equal to
            */

            Console.WriteLine("Denne sætning bliver skrevet lige meget hvad.");

            if(sentence[1] == 'b') Console.WriteLine("Det andet bogstav var b!");
            else if(sentence[1] == 'c') Console.WriteLine("Det andet bogstav er c!");
            else if(sentence[1] == 'd') Console.WriteLine("Det andet bogstav er d!");
            else Console.WriteLine("Sætningens andet bogstav var hverken b, c eller d.");

            while(Console.ReadLine()[0] != 'a')
            { //Hvis der kun er en linje kode, behøver man ikke tuborg-klammer.
                Console.WriteLine("The sentence didn't start with a. Try again!");
            }

            do
            {
                Console.WriteLine("Write a sentence starting with b.");
            } while(Console.ReadLine()[0] != 'b'); //Det eneste statement, som skal bruge semi-colon i slutningen.

            switch(Console.ReadLine()[0])
            {
                case 'a':
                    Console.WriteLine("You wrote a!");
                    break;

                case 'b':
                    Console.WriteLine("You wrote b!");
                    break;
                
                case 'c':
                    Console.WriteLine("You wrote c!");
                    break;
            }
        }
    }
}
