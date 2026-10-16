using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_2
{
   
    internal class Program
    {
        static bool NumaraVarMi(List<string> liste, string aranan)
        {
            foreach (string numara in liste)
            {
                if (numara == aranan)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            /*LİSTEDE ARAMA
             * •bool NumaraVarMi(List<string> liste, string aranan)
               •Contains kullanmadan foreach ile ara.
               •İlk eleman, son eleman ve olmayan numarayı dene.
               •Boş listede sonucun false olduğunu doğrula.
            */
            List<string> numaraListesi = new List<string> { "1001", "1002", "1003","1004"};
           Console.WriteLine(NumaraVarMi(numaraListesi, "1001")); // true
           Console.WriteLine(NumaraVarMi(numaraListesi, "1004")); // true
            Console.WriteLine(NumaraVarMi(numaraListesi, "1005")); // false
            List<string> bosListe = new List<string>();
            Console.WriteLine(NumaraVarMi(bosListe, "1001")); // false
        }
    }
}
