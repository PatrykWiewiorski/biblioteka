using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biblioteka
{
    public class Biblioteka
    {
        public List<Ksiazka> Ksiazki { get; set; } = new List<Ksiazka>();
        
        public void DodajKsiazke(Ksiazka ksiazka)
        {
            Ksiazki.Add(ksiazka);
        }
        private void WypiszDaneKsiazki(Ksiazka ksiazka)
        {
            Console.WriteLine($"Dane książki: {ksiazka.Tytul} - {ksiazka.Imie} {ksiazka.Nazwisko}, Data wydania: {ksiazka.Datawydania}r.");
        }
        
        public void ZnajdzKsiazkePoTytule(string tytul)
        {
            var ksiazka = Ksiazki.FirstOrDefault(c => c.Tytul == tytul);

            if(ksiazka == null)
            {
                Console.WriteLine("Nie znaleziono takiej książki.");
            }else
            {
                WypiszDaneKsiazki(ksiazka);
            }
        }
             public void ZnajdzKsiazkePoNazwisku(string nazwisko)
        {
            var ksiazka = Ksiazki.FirstOrDefault(c => c.Nazwisko == nazwisko);

            if(ksiazka == null)
            {
                Console.WriteLine("Nie znaleziono takiej książki.");
            }else
            {
                WypiszDaneKsiazki(ksiazka);
            }


        }

    }
}