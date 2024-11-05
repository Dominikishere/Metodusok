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
    }
}
