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

                    int u = 0;

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
                        Console.WriteLine("Det her er 4. opgave");
                        Console.WriteLine();

                        double Kage = 23.56;
                        double ol = 34.67;
                        double polse = 65.34;

                        Console.WriteLine($"Kage    {Kage}");
                        Console.WriteLine($"ol    {ol}");
                        Console.WriteLine($"polse     {polse}");

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 5) // opgave 1.5
                    {
                        Console.WriteLine("Det her er 5. opgave");
                        Console.WriteLine();

                        Console.WriteLine("Hvad er dit navn?");
                        string navn = Console.ReadLine();

                        int alder = 0;
                        int h = 1;

                        while (h == 1)
                        {
                            Console.WriteLine("Hvor gammel er du?");

                            try
                            {
                                alder = Convert.ToInt32(Console.ReadLine());
                                h = 0;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Fejl !");
                                Console.ReadLine();
                            }
                        }

                        Console.WriteLine($"Jeg hedder {navn} og er {alder} gammel");

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 6) // opgave 1.6
                    {
                        double radius = 0;
                        int h = 1;

                        while (h == 1)
                        {
                            Console.WriteLine("intast radius af en cirkel");

                            try
                            {
                                radius = Convert.ToDouble(Console.ReadLine());
                                h = 0;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Fejl !");
                                Console.ReadLine();
                            }
                        }

                        Console.WriteLine(Math.Pow(radius, 2) * Math.PI);

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                }

                while (i == 2) // Undermenu 2.0
                {
                    Console.WriteLine("Du har valgt Strings");

                    Console.WriteLine("\n1. opgave\n2. opgave\n3. opgave\n4. opgave\nB - tilbage");
                    Console.WriteLine();

                    opgaveSvar = Console.ReadLine();

                    int u = 0;

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

                    while (u == 1) // opgave 2.1
                    {
                        Console.WriteLine("Det her er 1. opgave");
                        Console.WriteLine();

                        int tal = 4;
                        double kommaTal = 7.21;
                        string skrift = "Hej";

                        Console.WriteLine(tal);
                        Console.WriteLine(kommaTal);
                        Console.WriteLine(skrift);

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 2) // opgave 2.2
                    {
                        Console.WriteLine("Det her er 2. opgave");
                        Console.WriteLine();

                        int tal = 4;
                        double kommaTal = 7.21;
                        string skrift = "Hej";

                        tal = 2;
                        kommaTal = 9.52;
                        skrift = "Godag";

                        Console.WriteLine(tal);
                        Console.WriteLine(kommaTal);
                        Console.WriteLine(skrift);

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 3) // opgave 2.3
                    {
                        Console.WriteLine("Det her er 3. opgave");
                        Console.WriteLine();

                        string jul = "I dag har vi den 24. December.";

                        Console.WriteLine(jul);

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 4) // opgave 2.4
                    {
                        Console.WriteLine("Det her er 4. opgave");
                        Console.WriteLine();

                        double maengde = 200.50;
                        string ord = "Jeg har";
                        string ord2 = "kr. i banken";

                        Console.WriteLine($"{ord} {maengde}{ord2}");

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                }

                while (i == 3) // Undermenu 3.0
                {
                    Console.WriteLine("Du har valgt Arimetiske udtryk");

                    Console.WriteLine("\n1. opgave\nB - tilbage");
                    Console.WriteLine();

                    opgaveSvar = Console.ReadLine();

                    int u = 0;

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

                    while (u == 1) // opgave 3.1
                    {
                        Console.WriteLine("Det her er 1. opgave");
                        Console.WriteLine();

                        int res1 = 2 + 1 * 2;
                        int res2 = (2 + 1) * 2;
                        double res3 = 5 / 2;
                        int res4 = 8 % 3;
                        int res5 = 1 - 5;

                        Console.WriteLine($"2 + 1 * 2 = {res1}");
                        Console.WriteLine($"(2 + 1) * 2 = {res2}");
                        Console.WriteLine($"5 / 2 = {res3}");
                        Console.WriteLine($"8 % 3 = {res4}");
                        Console.WriteLine($"1 - 5 = {res5}");

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                }

                while (i == 4) // Undermenu 4.0
                {
                    Console.WriteLine("Du har valgt Variabler i udtryk");

                    Console.WriteLine("\n1. opgave\n2. opgave\nB - tilbage");
                    Console.WriteLine();

                    opgaveSvar = Console.ReadLine();

                    int u = 0;

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

                    while (u == 1) // opgave 4.1
                    {
                        Console.WriteLine("Det her er 1. opgave");
                        Console.WriteLine();

                        int tal1 = 4;
                        int tal2 = 13;
                        int tal3 = 21;
                        int result = 0;

                        Console.WriteLine($"tal1 = {tal1}");
                        Console.WriteLine($"tal2 = {tal2}");
                        Console.WriteLine($"tal3 = {tal3}");

                        result = tal1 + tal2 / tal3;

                        Console.WriteLine($"result = {result}");

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 2) // opgave 4.2
                    {
                        Console.WriteLine("Det her er 2. opgave");
                        Console.WriteLine();

                        int tal1 = 4;
                        double tal2 = 13.62;
                        int tal3 = 21;
                        double result = 0;

                        Console.WriteLine($"tal1 = {tal1}");
                        Console.WriteLine($"tal2 = {tal2}");
                        Console.WriteLine($"tal3 = {tal3}");

                        result = tal1 * 5 + tal2 / tal3 -30;

                        Console.WriteLine($"result = {result}");

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                }

                while (i == 5) // Undermenu 5.0
                {
                    Console.WriteLine("Du har valgt Arimetiske udtryk");

                    Console.WriteLine("\n1. opgave\nB - tilbage");
                    Console.WriteLine();

                    opgaveSvar = Console.ReadLine();

                    int u = 0;

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

                    while (u == 1) // opgave 5.1
                    {
                        Console.WriteLine("Det her er 1. opgave");
                        Console.WriteLine();

                        int var1 = 8;
                        int var2 = 15;

                        Console.WriteLine($"var1 = {var1}");
                        Console.WriteLine($"var2 = {var2}");

                        bool boolean = var1 > var2;

                        Console.WriteLine($"boolean = {boolean}");

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                }

                while (i == 6)
                {
                    Console.WriteLine("Du har valgt Variabler");

                    Console.WriteLine("\n1. opgave\n2. opgave\n3. opgave\n4. opgave\n5. opgave\n6. opgave\nB - tilbage");
                    Console.WriteLine();

                    opgaveSvar = Console.ReadLine();

                    int u = 0;

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
                }

            }

        }
    }
}

