using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkceKarakterDegistir
{
    class Program
    {
        static void Main(string[] args)
        {
            string KarakterDonustur(string kelime)
            {
                kelime = kelime.Replace("ı", "i");
                kelime = kelime.Replace("ğ", "g");
                kelime = kelime.Replace("ü", "u");
                kelime = kelime.Replace("ş", "s");
                kelime = kelime.Replace("ö", "o");
                kelime = kelime.Replace("ç", "c");
                kelime = kelime.Replace("Ğ", "G");
                kelime = kelime.Replace("Ü", "U");
                kelime = kelime.Replace("Ş", "S");
                kelime = kelime.Replace("İ", "I");
                kelime = kelime.Replace("Ç", "C");
                kelime = kelime.Replace("Ö", "O");

                return kelime;
            }

            Console.WriteLine("Dönüştürülmesi istenen kelime: ");
            string donusecek = Console.ReadLine();
            string donusen = KarakterDonustur(donusecek);
            Console.WriteLine(donusen);
            Console.ReadKey();
        }
    }
}
