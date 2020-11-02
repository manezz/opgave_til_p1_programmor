using Opgave_til_p1_programmor;
using System;

namespace opgave_til_p1_programmor
{
    class Bog : Program
    {
        // Vaerdier til 12.1
        // Pris bliver også Brugt til 10.2
        int Pris { get; set; }
        string Titel { get; set; }

        public int saetBogInt1 = 150;
        public int saetBogInt2 = 240;
        public string saetBogString1 = "Sherlock Holmes";
        public string saetBogString2 = "Moby Dick";

        public void PrintInfo()
        {
            Console.WriteLine("Jeg er en bog.");
        }

        public void SherlockHolmes()
        {
            Pris = 150;
            Titel = "Sherlock Holmes";

            Console.WriteLine($"{Titel} - koster {Pris} kr.");
        }

        public void MobyDick()
        {
            Pris = 240;
            Titel = "Moby Dick";

            Console.WriteLine($"{Titel} - koster {Pris} kr.");
        }

        public void HarRaad(string bogPengeString)
        {
            Pro fejl1 = new Pro();

            Pris = 150;
            int bogPenge = 0;
             
            try
            {
                bogPenge = Convert.ToInt32(bogPengeString);
                Console.WriteLine();
            }
            catch (Exception)
            {
                fejl1.Fejl();
            }
            

            if (bogPenge >= Pris)
            {
                Console.WriteLine("Jeg har raad.");
            }
            else
            {
                Console.WriteLine("Jeg har desvaere ikke raad.");
            }
        }

        public void SaetAlle()
        {
            Console.WriteLine("Alle Variabler");
            Console.WriteLine();

            Console.WriteLine($"var 1 - {saetBogInt1}");
            Console.WriteLine($"var 2 - {saetBogInt2}");
            Console.WriteLine($"var 3 - {saetBogString1}");
            Console.WriteLine($"var 4 - {saetBogString2}");
        }

        public void SaetEn()
        {
            Console.WriteLine("En Variable");
            Console.WriteLine();

            Console.WriteLine($"var 1 - {saetBogString1}");
        }
    }
}
