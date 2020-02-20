using System;

namespace DuD_Attributswerte_Generieren
{
    public class Würfel
    {
        private int seitenZahl;
        private int startZahl; //Die Zahl mit der der Würfel startet
        private Random rand;

        public Würfel(int seitenzahl)
        {
            this.seitenZahl = seitenzahl;
            this.startZahl = 1;
            rand = new Random();
        }
        public Würfel(int seitenzahl, int startzahl)
        {
            this.seitenZahl = seitenzahl;
            this.startZahl = startzahl;
            rand = new Random();
        }
        public int würfeln()
        {
            return rand.Next(this.startZahl, this.seitenZahl);
        }
    }
}
