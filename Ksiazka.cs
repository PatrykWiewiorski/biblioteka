using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biblioteka
{
    public class Ksiazka
    {
        public Ksiazka(string tytul, string imie, string nazwisko, string datawydania)
        {
            Tytul = tytul;
            Imie = imie;
            Nazwisko = nazwisko;
            Datawydania = datawydania;
        }
        public string Tytul { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Datawydania { get; set; }
        
        
    }
}