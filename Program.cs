using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biblioteka
{
    class Program
    {
        
        static void Main(string[] args)
        {
        m:
            Console.WriteLine("Witaj w konsolowej aplikacji biblioteki!");

            Console.WriteLine("Wybierz 1 i wciśnij enter aby dodać książkę");
            Console.WriteLine("Wybierz 2 i wciśnij enter aby znaleźć książkę po tytule");
            Console.WriteLine("Wybierz 3 i wciśnij enter aby znaleźć książkę po imieniu i nazwisku autora");

            int wybor = Convert.ToInt32(Console.ReadLine());
            
            var Zarzadzanie = new zarzadzanie();
            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Podaj Tytuł książki");
                    var tytul = Console.ReadLine();
                     Console.WriteLine("Podaj Imię autora książki");
                    var imie = Console.ReadLine();
                     Console.WriteLine("Podaj Nazwisko autora książki");
                    var nazwisko = Console.ReadLine();
                     Console.WriteLine("Podaj rok wydania książki w formacie dd-mm-rrrr");
                    var datawydania = Console.ReadLine();
                    Console.WriteLine("Kontakt został pomyślnie dodany!");

                    var nowaksiazka = new Ksiazka(tytul,imie,nazwisko,datawydania);

                    Zarzadzanie.DodajKsiazke(nowaksiazka);
                    goto m;
                case 2:
                    Console.WriteLine("Podaj tytuł książki");
                    var tytul1 = Console.ReadLine();

                        Zarzadzanie.ZnajdzKsiazkePoTytule(tytul1);
                    goto m;
                case 3:
                     goto m;
                default:
                Console.WriteLine("Podaną złą wartość!");
                goto m;

            }
        }
    }
}
