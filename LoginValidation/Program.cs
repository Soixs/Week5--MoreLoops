using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajalt kasutajatunnuse ja salasõna
            //Kui kasutajatunnus on "admin" ja salasõna "admin1234"
            //Kuvatakse konsoolis "Tere tulemast!
            //Muul juhul kuvab konsool "Vale kasutajatunnus või salasõna - Proovi uuesti!"
            //Kasutajal on kolm katset

            //WHILE loop

            {
                

                int i = 0;

                while (i < 3)


                {

                    Console.WriteLine("Sisestage kasutajatunnus: ");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Sisestage oma salasõna: ");
                    string userPassword = Console.ReadLine();


                    if (userName != "admin" || userPassword != "admin1234")
                    {
                        i++;
                        Console.WriteLine($"Vale! Katseid jäänud: {3 - i}");

                    }

                    else
                    {
                        Console.WriteLine("Tere tulemast!");
                        i = 3;
                    }

                }
            }
        }
    }
}
