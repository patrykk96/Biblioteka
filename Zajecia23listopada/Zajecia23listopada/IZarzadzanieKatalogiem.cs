﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia23listopada
{
    interface IZarzadzanieKatalogiem
    {
        void WyszukajPoTytule(string tytul);
        void WyszukajPoId(int id);
        void WypiszWszystko();


    }
}
