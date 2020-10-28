using Opgave_til_p1_programmor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_til_p1_programmor
{
    class Bog
    {
        public double bogPris = 150;
        public double bogPenge = 0;

        public void PrintInfo()
        {
            Console.WriteLine("Jeg er en bog.");
        }

        public void HarRaad()
        {
            Console.WriteLine("Hvor mange penge har du?");
            Console.WriteLine();

            bogPenge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (bogPenge >= bogPris)
            {
                Console.WriteLine("Jeg har raad.");
            }
            else
            {
                Console.WriteLine("Jeg har desvaere ikke raad.");
            }
        }

    }
}
