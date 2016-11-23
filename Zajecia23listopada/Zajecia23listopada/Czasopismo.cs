using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia23listopada
{
    class Czasopismo : Pozycja
    {
        private int numer;

         public Czasopismo() { }

        public Czasopismo (string tytul, int id, string wydawnictwo, int rokWydania, int numer)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.numer = numer;
            
            
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: {0}, id: {1}, wydawnictwo: {2}, rok wydania: {3}, numer: {4}", tytul, id, wydawnictwo, rokWydania, numer);
            
        }
    }
}
