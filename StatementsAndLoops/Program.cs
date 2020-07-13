using System;
using System.Collections.Generic;

namespace StatementsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();

            if(sentence[0] == 'a') //Hvis det første bogstav i sætningen er lig med a,
            { //Udfør koden der er i næste "scope" (tuborg-klammer {})
                Console.WriteLine("Det første bogstav var a!");
            }

            /*
                Her er de forskellige "Conditional Operators".
                ==  -> is equal to
                !=  -> is not equal to
                !   -> not (så !true bliver false, og !false bliver true)
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

            List<int> listOfIntegers = new List<int>{1, 2, 3, 4, 5};
            foreach(int integer in listOfIntegers)
            {
                Console.WriteLine(integer);
            }

            /*
                Her starter vi med en variabel vi navngiver i (for index).
                Efter initialiseringen er kørt en gang, kører den ikke igen før loopet er kaldt fra ny.

                Efter initialiseringen, bliver den tilhørende "condition" (i < listOfIntegers.Count) tjekket, om det er korrekt.
                Så bliver koden kørt, hvor variablen i starter med at havde værdien 0.
                Dette betyder, at værdien på plads 0 i listen, bliver printet.

                Efter koden inde i loopet er blevet kørt, bliver det sidste stykke af for-loopet kørt. (i++)
                i++ er det samme som:
                i += 1;
                eller
                i = i + 1;
                Den inkrementerer værdien af variablen i med 1.

                Efter denne inkrementeringen bliver der tjekket om i er mindre end længden af listens længde (listOfIntegers.Count).
                Hvis dette er korrekt (true), kører koden om igen.

                Dette vil sige, at loopet kører på følgende måde.
                Initialiser i 
                -> Tjek condition (i < listOfIntegers.Count).
                -> Kør koden med værdien af i.
                -> Inkrementer i med 1.
                -> Tjek condition. Hvis den er korrekt, så
                -> Kør koden med den ny værdi af i.
                -> Inkrementer i med 1.
                osv. osv. osv.

                Dette bliver gjort indtil vores condition i < listOfIntegers.Count bliver false.
                Hvis dette sker, går programmet videre.
            */
            for(int i = 0; i < listOfIntegers.Count; i++) //i < længden af listen, fordi hvis index er lig eller over listens længde, er vi nået til slutningen af listen.
            {
                Console.WriteLine(listOfIntegers[i]);
            }
        }
    }
}
