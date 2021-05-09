using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biblioteka
{
    public class zarzadzanie
    {
        public List<Ksiazka> Ksiazki { get; set; }
        
        public void DodajKsiazke(Ksiazka ksiazka)
        {
            Ksiazki.Add(ksiazka);
        }
        
        public void ZnajdzKsiazkePoTytule(string tytul)
        {
            var ksiazka = Ksiazki.FirstOrDefault(c => c.Tytul == tytul);

            if(ksiazka == null)
            {
                Console.WriteLine("Nie znaleziono takiej książki.");
            }else
            {
                Console.WriteLine( $"Dane książki: {ksiazka.Tytul} - {ksiazka.Imie} {ksiazka.Nazwisko}, {ksiazka.Datawydania}r.");
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
                Console.WriteLine( $"Dane książki: {ksiazka.Tytul} - {ksiazka.Imie} {ksiazka.Nazwisko} , {ksiazka.Datawydania}r.");
            }


        }

    }
}