using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //Sortiert Array absteigend
                Array.Sort<int>(werte,
                    new Comparison<int>(
                            (i1, i2) => i2.CompareTo(i1)
                    ));

                string outputWert = ArrayToString(werte);
                if(outputWert.Substring(outputWert.Length-1)==",")
                {
                    outputWert = outputWert.Substring(0, outputWert.Length - 1);
                }
                Console.WriteLine("Die Attributswerte sind: " + outputWert);
                Console.WriteLine("Sollen erneut Attributswerte generiert werden? j=ja");
                string eingabe = Console.ReadLine();

                isWiederhole = eingabe.ToUpper() == "J";
            }

        }


        private static string ArrayToString(int[] werte)
        {
            string sReturn = string.Empty;

            foreach (int i in werte)
            {
                sReturn += i.ToString() + ",";
            }

            return sReturn;
        }
    }
}
