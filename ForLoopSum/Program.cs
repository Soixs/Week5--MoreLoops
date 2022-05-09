using System;

namespace ForLoopSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajalt sisestada kolm numbrit
            //Programm kuvab nende numbrite summa

            {
                

                int sum = 0;

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Sisesta number: ");
                    int userNumber = Convert.ToInt32(Console.ReadLine());

                    sum = sum + userNumber;

                }

                Console.WriteLine($"Teie kogu summa: {sum}");
                Console.WriteLine("Kena päeva!");

            }
        }
    }
}
