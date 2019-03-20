using System;

namespace ooad_t1_z6
{
    class Program
    {
        public static string IzbrisisPodstring(String izraz, String podstring)
        {
            return izraz.Replace(podstring, "");
        }

        public static int NadjiPodstring(String izraz, String podstring)
        {
            if (izraz.Contains(podstring) == false)
                return -1;
            else
                return izraz.IndexOf(podstring);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite izraz/recenicu: ");
            String izraz = Console.ReadLine();
            Console.WriteLine("Unesite izraz/recenicu koju zelite izbaciti ako se pojavljuje u prethodnoj recenici: ");
            String podrsting = Console.ReadLine();

            Console.WriteLine("Recenica sa izbacemin podstringom \"{0} \" glasi: {1}", podrsting, IzbrisisPodstring(izraz, podrsting));

            if (NadjiPodstring(izraz, podrsting) == -1)
                Console.WriteLine("U unesenom izrazu se drugi izraz ne pojavljuje kao podstring");
            else
                Console.WriteLine("U unesenom izrazu se drugi izraz pojavljuje kao podstring, a prvo pojavljivanje je na indeksu {0}", NadjiPodstring(izraz, podrsting));

            Console.ReadLine();
        }
    }
}
