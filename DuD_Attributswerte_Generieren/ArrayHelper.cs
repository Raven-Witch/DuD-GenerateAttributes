using System;

namespace DuD_Attributswerte_Generieren
{
    public static class ArrayHelper
    {
        public static string ArrayToString(int[] werte)
        {
            string sReturn = string.Empty;

            foreach (int i in werte)
            {
                sReturn += i.ToString() + ",";
            }

            return sReturn;
        }

        public static int getSumme(int[] werte)
        {
            int iReturn = 0;

            foreach (int i in werte)
            {
                iReturn += i;
            }

            return iReturn;
        }

        public static void getSortAsc(ref int[] werte)
        {
            Array.Sort<int>(werte);
        }

        public static void getSortDesc(ref int[] werte)
        {
            getSortAsc(ref werte);
            Array.Reverse(werte);
        }
    }
}
