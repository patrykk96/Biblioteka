using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia23listopada
{
    class Autor : Osoba
    {
        private string narodowosc;

        public Autor()
        {
            
        }

        public Autor(string imie, string nazwisko, string narodowosc)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.narodowosc = narodowosc;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("imie: {0}, nazwisko: {1}, narodowosc: {2}",imie , nazwisko, narodowosc);

        }
    }
}
