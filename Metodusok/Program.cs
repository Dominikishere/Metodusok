using System.Data;
using System.Runtime.ExceptionServices;

namespace Metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> primSzamok = Primszamok(1, 1000);
            foreach (int szam in primSzamok)
            {
                Console.Write(szam + ", ");
            }
            Console.WriteLine();
            string szoveg = "Ez az óra jó, de sajnos nincs itt Koczka tanár úr.";
            int darab = szovegElofordulas(szoveg, "Koczka");
            Console.WriteLine($"Hányszor szerepel Koczka a szövegben: {darab} ");

        }

        static List<int> Primszamok(int kezdo,int veg)
        {
            List<int> Primlista = new List<int>();
            for (int i = kezdo; i < veg; i++)
            {
                if (PrimE(i))
                {
                    Primlista.Add(i);
                }
            }
            return Primlista;
        }

        static bool PrimE(int szam)
        {
            if (szam < 2) return false;
            for (int i = 2; i <= Math.Sqrt(szam); i++)
            {
                if (szam % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int szovegElofordulas(string szoveg,string alSzoveg)
        {
            int szam = 0;
            int index = szoveg.IndexOf(alSzoveg);
            while (index != -1)
            {
                szam++;
                index = szoveg.IndexOf(alSzoveg, index + 1);
            }
            return szam;
        }
    }
}
