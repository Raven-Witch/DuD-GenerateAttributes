using System;

namespace DuD_Attributswerte_Generieren
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWiederhole = true;
            //Sorgt dafür, dass der Random Seed nicht immer wieder neu gesetzt wird, und daher dieser ähnlich ist
            AttributswerteGenerator attributswerte = new AttributswerteGenerator();

            while (isWiederhole)
            {
                int[] werte = attributswerte.getAttributswerte();
                ArrayHelper.getSortDesc(ref werte);

                Console.WriteLine("Die Attributswerte sind: " + prepareForOutput(werte));
                Console.WriteLine("Sollen erneut Attributswerte generiert werden? j=ja");
                string eingabe = Console.ReadLine();

                isWiederhole = eingabe.ToUpper() == "J";
            }

        }

        private static string prepareForOutput(int[] werte)
        {
            string outputWert = ArrayHelper.ArrayToString(werte);
            if (outputWert.Substring(outputWert.Length - 1) == ",")
            {
                outputWert = outputWert.Substring(0, outputWert.Length - 1);
            }

            return outputWert;
        }


    }
}
