using System;


namespace _1_firstFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.Write("Imie "); //wypisz imie
            Console.WriteLine("Kasia: ");

            Console.WriteLine("# ");
            Console.WriteLine("##");
            Console.WriteLine("###");
            Console.WriteLine("####");
            Console.WriteLine("\n#\n##\n###\n####");

            string name;
            name = "janusz";

            //kontantenacja
            Console.WriteLine("Masz na imię: " + name);

            Console.WriteLine("Masz na imię:  {0}", name);

            int age = 20;
            Console.WriteLine("Masz na imię:  {0}, wiek: {1} ", age, name);

            /*
             * Użytkownik podaje zklawiatury długośc boku
             * Oblicz pole kwadratu
             */

            Console.Write("Podaj bok a: ");
            string a = Console.ReadLine();

            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wynosi: {0}", result);

            /*
             * Olicz pole trójkąta
             * dane podane z klawiatury
             */


            Console.ReadKey();
        }
    }
}
