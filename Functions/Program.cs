using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
                WriteLine er en funktion i klassen Console.
                WriteLine tager forskellige argumenter.
                Argumenter er de(n) variabel du smidder med når du kalder funktionen.
            */

            ThisIsATestFunctionIWroteToWriteAStringToTheConsole("Hello World From Custom Function"); //En funktion jeg skrev på linje 46.

            int x = Sum(2, 3); //Sum er en funktion jeg skrev på linje 41.
            Console.WriteLine(x);
        }

        /*
            Her har du functionen Sum, der tager to parametre.
            Den første parameter er en integer (int), som indeholder et tegn.
            Det andet parameter er også en integer, som indeholder en anden værdi.

            Syntax:

            Returntype functionName(Datatype variableName1, Datatype variableName2)
            {
                //do something with the variables. Fx.
                var result = variableName1 + variableName2;
                return result; //
            }

            Returntype er den datatype som i vil returnere fra funktionen. Fx int, float, double, bool, etc.
            void er en anden Returntype. Denne type indikerer at noget kode udføres, men at der ikke returneres en værdi.

            Et eksempel er Console.WriteLine(), der printer noget ud på konsollen, men en værdi returneres ikke til programmet efter det er blevet printet.
        */
        static int Sum(int firstParameter, int secondParameter)
        {
            return firstParameter + secondParameter; //Her returneres summen af de to tal.
        }

        static void ThisIsATestFunctionIWroteToWriteAStringToTheConsole(string test)
        {
            Console.WriteLine(test);
        }
    }
}
