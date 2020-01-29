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
            //Würfel w6 = new Würfel(6);
            //Console.WriteLine("Würfel würfelt eine " + w6.würfeln());
            AttributswerteGenerator attributswerte = new AttributswerteGenerator();
            int[] werte = attributswerte.getAttributswerte();
            string outputWert = ArrayToString(werte);
            if(outputWert.Substring(outputWert.Length-1)==",")
            {
                outputWert = outputWert.Substring(0, outputWert.Length - 1);
            }
            Console.WriteLine("Die Attributswerte sind: " + outputWert);

            Console.ReadLine();
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
