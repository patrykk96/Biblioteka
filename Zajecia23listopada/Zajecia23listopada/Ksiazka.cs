using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia23listopada
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        Autor autor;

        public Ksiazka() { }

        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, Autor autor)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.liczbaStron = liczbaStron;
            this.autor = autor;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: {0}, id: {1}, wydawnictwo: {2}, rok wydania: {3}, liczba stron: {4}", tytul, id, wydawnictwo, rokWydania, liczbaStron);
            Console.WriteLine("Autor: {0}", autor);
        }
    }
}
