using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_til_p1_programmor
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "";
            string opgaveSvar = "";

            int i = 0;
            int u = 0;

            while (i == 0) // Hovedemenu 0.0
            {
                Console.WriteLine("Vælg et emne (svar med et tal fx. 3 eller 7)");

                Console.WriteLine("\n1. Variabler\n2. Strings\n3. Aritmetiske udtyk\n4. Variabler i udtryk\n5. Boolske variabler\n6. If-else statements\n7. Switch Case\n8. Loops\n9. Udvidet kontrolssrulurer\n10. Metoder og instanser\n11. Returtyper og paremetre\n12. Instancevariabler\n13. Nedarvning\n14. Konstruktors\n15. Arrays\n16. Gennemløb af arrays\n17. Public, Private og Protected\nL - lukker program");
                Console.WriteLine();

                svar = Console.ReadLine();

                if (svar == "l" || svar == "L")
                {
                    return;
                }
                else
                {
                    try
                    {
                        i = Convert.ToInt32(svar);
                    }
                    catch (Exception)
                    {
                        Console.Clear();

                        Console.WriteLine("Fejl !");

                        svar = "";

                        Console.ReadLine();
                    }
                }

                Console.Clear();

                while (i == 1) // Undermenu 1.0
                {
                    Console.WriteLine("Du har valgt Variabler");

                    Console.WriteLine("\n1. opgave\n2. opgave\n3. opgave\n4. opgave\n5. opgave\n6. opgave\nB - tilbage");
                    Console.WriteLine();

                    opgaveSvar = Console.ReadLine();

                    if (opgaveSvar == "b" || opgaveSvar == "B")
                    {
                        opgaveSvar = "";
                        i = 0;
                    }
                    else
                    {
                        try
                        {
                            u = Convert.ToInt32(opgaveSvar);
                        }
                        catch (Exception)
                        {
                            Console.Clear();

                            Console.WriteLine("Fejl !");

                            opgaveSvar = "";
                            u = 0;

                            Console.ReadLine();
                        }
                    }

                    Console.Clear();

                    while (u == 1) // opgave 1.1
                    {
                        Console.WriteLine("Det her er 1. opgave");
                        Console.WriteLine();

                        int tal1;
                        int tal2;

                        tal1 = 5;
                        tal2 = 3;

                        Console.WriteLine(tal1);
                        Console.WriteLine(tal2);

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 2) // opgave 1.2
                    {
                        Console.WriteLine("Det her er 2. opgave");
                        Console.WriteLine();

                        int tal1;
                        int tal2;

                        tal1 = 5;
                        tal2 = 3;

                        Console.WriteLine(tal1);
                        Console.WriteLine(tal2);

                        Console.WriteLine();

                        Console.WriteLine($"Tal1 er {tal1}");
                        Console.WriteLine($"Tal2 er {tal2}");

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 3) // opgave 1.3
                    {
                        Console.WriteLine("Det her er 3. opgave");
                        Console.WriteLine();

                        string Navn = "Søren";
                        int Alder = 16;
                        double Penge = 1234.34;

                        Console.WriteLine($"Jeg hedder {Navn}, er {Alder} år gammel pg har tjent {Penge} kr. på at lappe cykler");

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 4) // opgave 1.4
                    {
                        Console.WriteLine("Det her er 3. opgave");
                        Console.WriteLine();

                        double Kage = 23.56;
                        double Øl = 34.67;
                        double pølse = 65.34;

                        //Con

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                }

            }

        }
    }
}

