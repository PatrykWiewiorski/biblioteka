namespace biblioteka
{
    public class dodanieks
    {
        public dodanieks(string tytul, string imie, string nazwisko, string datawydania)
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