using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuD_Attributswerte_Generieren
{
    public class AttributswerteGenerator
    {
        Würfel würfel;
        int anzahlWürfe;
        int anzahlWerte;
        int anzahlMaxwerte;
        bool outputConsole;

        public AttributswerteGenerator()
        {
            würfel = new Würfel(6);
            this.anzahlWerte = 6;
            this.anzahlWürfe = 4;
            this.anzahlMaxwerte = 3;
            this.outputConsole = false;
        }

        public AttributswerteGenerator(bool outputConsole)
        {
            würfel = new Würfel(6);
            this.anzahlWerte = 6;
            this.anzahlWürfe = 4;
            this.anzahlMaxwerte = 3;
            this.outputConsole = outputConsole;
        }

        public AttributswerteGenerator(int anzahlWerte, int anzahlWürfe, int anzahlMaxwerte)
        {
            würfel = new Würfel(6);
            this.anzahlWerte =anzahlWerte;
            this.anzahlWürfe = anzahlWürfe;
            this.anzahlMaxwerte = anzahlMaxwerte;
            this.outputConsole = false;
        }

        public AttributswerteGenerator(int anzahlWerte, int anzahlWürfe, int anzahlMaxwerte, bool outputConsole)
        {
            würfel = new Würfel(6);
            this.anzahlWerte = anzahlWerte;
            this.anzahlWürfe = anzahlWürfe;
            this.anzahlMaxwerte = anzahlMaxwerte;
            this.outputConsole = outputConsole;
        }

        public int[] getAttributswerte()
        {
            int[] höchsteWerte = new int[this.anzahlWerte];

            for (int i = 0; i < höchsteWerte.Length; i++)
            {
                List<int> wurfErgebnisse = getWurfErgebnisse();
                if(outputConsole) Console.WriteLine("Gewürfelt wurde: " + ArrayToString(wurfErgebnisse.ToArray()));

                int[] summenWerte = getMaxwerte(ref wurfErgebnisse);
                if (outputConsole) Console.WriteLine("Maxergebnisse sind: " + ArrayToString(summenWerte));

                höchsteWerte[i] = getMax(summenWerte);
                if (outputConsole) Console.WriteLine("Summenwert von " + höchsteWerte[i] + " wurde hinzugefügt");

            }

            return höchsteWerte;
        }

        private List<int> getWurfErgebnisse()
        {
            List<int> wurfErgebnisse = new List<int>();
            for (int w = 1; w <= this.anzahlWürfe; w++)
            {
                wurfErgebnisse.Add(würfel.würfeln());
            }
            return wurfErgebnisse;
        }

        private int[] getMaxwerte(ref List<int> werte)
        {
            int[] summenWerte = new int[this.anzahlMaxwerte];
            for (int s = 0; s < summenWerte.Length; s++)
            {
                summenWerte[s] = werte.Max<int>();
                werte.Remove(summenWerte[s]);
            }

            return summenWerte;
        }

        private int getMax(int[] werte)
        {
            int iReturn = 0;

            foreach(int i in werte)
            {
                iReturn += i;
            }

            return iReturn;
        }

        private string ArrayToString(int[] werte)
        {
            string sReturn = string.Empty;

            foreach(int i in werte)
            {
                sReturn += i.ToString() + ",";
            }

            return sReturn;
        }

    }
}
