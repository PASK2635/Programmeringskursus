using System;
using System.Collections.Generic;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax: Datatype variableName = value; (= value er valgfrit).
            int iV = 1; //Heltal
            double dV = 1.1; //Decimaltal. Default er double.
            float fV = 1.1f; //Decimaltal. Fylder mindre, men kan indeholde mindre værdier. Skal indikeres med f efter tallet.
            char cV = 'A'; //Indeholder et tegn/ciffer. Indikeres med apostroffer ''.
            string sV = "Dette er det bedste kursus nogensinde."; //Indeholder en liste af tegn/cifre. Indikeres med gåseøjne "".
            bool bV = true; //Indeholder true eller false.

            List<int> lI = new List<int>{1, 2, 3, 4, 5}; //List<T> er en liste af typen T. I dette tilfælde har jeg valgt int (integer).
            
            int[] aI = new [] { 1, 3, 5, 7, 9 }; //[] er indikeringen af en array. Array er næsten det samme som List, men størrelsen kan ikke ændres i løbet af programmet.

            //Den næste kode indeholder loops. Ikke fokuser på dette. De printer de tidligere lister af integers.
            lI.Add(6); //Som sagt, kan en liste ændre størrelse løbende.

            //For hvert <datatype> <name> (integer i dette tilfælde) i listen "lI", print integer og derefter et mellemrum.
            foreach(int integer in lI)
                Console.Write(integer+" ");
            
            Console.Write('\n'); //Tegnet \n står for newline. AKA: Enter.

            foreach(var integer in aI)
                Console.Write(integer+" ");
            
            Console.Write('\n');

            //Den følgende kode ødelægger programmet, da størrelsen på en array ikke kan ændres. Slet "//" for at udkommenter det eller lav shortcut Ctrl+K Ctrl+U. 
            aI[5] = 1;
            //IndexOutOfRangeException indikerer, at den plads man prøvede at få fat i, var uden for arrayets indhold.
        }
    }
}
