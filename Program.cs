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
                case1:
                    Console.WriteLine("Podaj Imię autora");



            }
        }
    }
}
