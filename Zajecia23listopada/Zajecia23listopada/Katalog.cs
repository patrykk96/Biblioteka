using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia23listopada
{
    class Katalog
    {
        private string dzialTematyczny;
        List<Pozycja> listaPozycji = new List<Pozycja>();

        public Katalog() { }

        public Katalog(string dzialTematyczny, List<Pozycja> listaPozycji)
        {
            this.dzialTematyczny = dzialTematyczny;
            this.listaPozycji = listaPozycji;
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            listaPozycji.Add(pozycja);
        }

        
    }
}
