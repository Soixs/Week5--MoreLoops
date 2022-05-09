using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängus osaleb kaks mängijat- arvuti (cpu) ja kasutaja (user);
            //Mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskas rohkem, ongi mängu võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulutab võitja

            Console.WriteLine("Tere tulemast mängu!");
            Console.WriteLine("  ");

            Console.WriteLine("Järgnevalt viskavad arvuti ning kasutaja kolm korda täringut.");
            Console.WriteLine("  ");

            Random rnd = new Random();

            int cpuRandom = 0;
            int userRandom = 0;
            int cpuSum = 0;
            int userSum = 0;

            for (int i = 0; i < 3; i++)

            {
                cpuRandom = rnd.Next(1, 7);
                cpuSum = cpuSum + cpuRandom;
                userRandom = rnd.Next(1, 7);
                userSum = userSum + userRandom;
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
                Console.WriteLine("  ");
            }

            Console.WriteLine($"Arvuti skoor kokku: {cpuSum}; Mängija skoor kokku: {userSum}");
            Console.WriteLine("  ");

            if (cpuSum < userSum)
            {
                Console.WriteLine("Kasutaja on mängu võitnud - Palju õnne!");
            }
            else if (cpuSum > userSum)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
            }
            else
            {
                Console.WriteLine("Visked jäid viiki!");

            }

        }
    }
}
