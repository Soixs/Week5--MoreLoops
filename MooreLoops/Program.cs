using System;

namespace MooreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajalt kasutajatunnuse ja salasõna
            //Kui kasutajatunnus on "admin" ja salasõna "admin1234"
            //Kuvatakse konsoolis "Tere tulemast!
            //Muul juhul kuvab konsool "Vale kasutajatunnus või salasõna - Proovi uuesti!"

            Console.WriteLine("Sisestage kasutajatunnus");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisestage oma salasõna");
            string userPassword = Console.ReadLine();

            //AND lahendus

            if (userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast tagasi!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti!");
            }
        }
    }
}
