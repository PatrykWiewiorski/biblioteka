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
            
            switch (wybor)
            {
                case 1:
                    goto m;
                case 2:
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
