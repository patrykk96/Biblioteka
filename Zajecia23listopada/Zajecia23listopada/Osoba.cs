using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia23listopada
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;

        public Osoba()
        {
            imie = "Jan";
            nazwisko = "Kowalski";
        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
