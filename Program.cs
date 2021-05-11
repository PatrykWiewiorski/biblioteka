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
            Console.WriteLine("Witaj w konsolowej aplikacji biblioteki!");

            Console.WriteLine("Wybierz 1 i wciśnij enter aby dodać książkę");
            Console.WriteLine("Wybierz 2 i wciśnij enter aby znaleźć książkę po tytule");
            Console.WriteLine("Wybierz 3 i wciśnij enter aby znaleźć książkę po imieniu i nazwisku autora");

            var wybor = Convert.ToInt32(Console.ReadLine());
            
            var biblioteka = new Biblioteka();

        while(true)
         {
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

                    biblioteka.DodajKsiazke(nowaksiazka);
                    break;
                case 2:
                    Console.WriteLine("Podaj tytuł książki");
                    var tytul1 = Console.ReadLine();

                        biblioteka.ZnajdzKsiazkePoTytule(tytul1);
                    break;
                case 3:
                Console.WriteLine("Podaj Nazwisko autora książki");
                    var nazwisko1 = Console.ReadLine();

                        biblioteka.ZnajdzKsiazkePoNazwisku(nazwisko1);
                     break;
                default:
                Console.WriteLine("Podaną złą wartość!");
                    break;


            }
                Console.WriteLine("Wybierz ponownie co chesz zrobić.");
                wybor = Convert.ToInt32(Console.ReadLine());
         }
        }
    }
}
