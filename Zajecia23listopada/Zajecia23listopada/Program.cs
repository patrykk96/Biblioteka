using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia23listopada
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROGRAM3 - BIBLIOTEKA

            Autor autor = new Autor("Henryk", "Sienkiewicz", "Polak");
            Ksiazka ksiazka = new Ksiazka("abc", 1, "pwn", 1900, 500, autor);
            Czasopismo gazeta = new Czasopismo("bcd", 2, "bauer", 2016, 1);

            autor.WypiszInfo();
            ksiazka.WypiszInfo();
            gazeta.WypiszInfo();

            Console.ReadKey();
        }
    }
}
