using System;

namespace biblioteka
{
    class Program
    {
        struct ksiazka{
            public string tytul;
            public string imie;
            public string nazwisko;
            public string datawydania;

        }
        static void Main(string[] args)
        {
            ksiazka ks1 =   new ksiazka();

            Console.WriteLine("Witaj w konsolowej aplikacji biblioteki!");
            Console.WriteLine("Wybierz 1 i wciśnij enter aby dodać książkę");
            Console.WriteLine("Wybierz 2 i wciśnij enter aby znaleźć książkę po tytule");
            Console.WriteLine("Wybierz 1 i wciśnij enter aby znaleźć książkę po imieniu i nazwisku autora");

            int wybor = Convert.ToInt32(Console.ReadLine());
            
            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Podaj tytuł książki");
                    string tytul = Console.ReadLine();
                    Console.WriteLine("Podaj Imię autora książki");
                    string imie = Console.ReadLine();
                    Console.WriteLine("Podaj Nazwisko autora książki");
                    string nazwisko = Console.ReadLine();
                    Console.WriteLine("Podaj rok wydania książki");
                    string datawydania = Console.ReadLine();

                        ks1.tytul= tytul;
                        ks1.imie = imie;
                        ks1.nazwisko = nazwisko;
                        ks1.datawydania = datawydania;
                        
                    Console.WriteLine("Pomyślnie dodano książkę!");

                    break;
                case 2:
                     break;
                case 3:
                     break;
                default:
                Console.WriteLine("Podaną złą wartość!");
                break;

            }
        }
    }
}
