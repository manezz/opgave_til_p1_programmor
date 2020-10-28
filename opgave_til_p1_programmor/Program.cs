using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using opgave_til_p1_programmor;

namespace Opgave_til_p1_programmor
{
    class Program : Bog
    {
        public static string opgaveSvar = "";
        public static int i = 0;
        public static int u = 0;
        public static int maxOpgaver;

        public static string[] kategorier = {
            "Variabler",
            "Strings",
            "Aritmetiske Udtryk",
            "Variabler i Udtryk",
            "Boolske Variable",
            "If-Else Statements",
            "Switch Case",
            "Loops",
            "Udvidet Kontrolstrukturer",
            "Metoder og Instanser",
            "Returtyper og Paremetre",
            "Instancevariabler",
            "Nedarvning",
            "Konstruktors",
            "Arrays",
            "Gennemlob af Arrays",
            "Public, Private og Protected"
        };

        public class Pro : Program
        {
            public void Menu()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Du har valgt {kategorier[i - 1]}.");
                Console.ResetColor();
            }

            public void Back()
            {
                opgaveSvar = Console.ReadLine();

                u = 0;

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

            public void UnderMenu()
            {
                Console.WriteLine();
                for (int s = 1; s <= maxOpgaver; s++)
                {
                    Console.WriteLine($"{s}. opgave");
                }
                Console.WriteLine("B - Tilbage");
                Console.WriteLine();
            }

            public void Slut()
            {
                Console.ReadLine();
                Console.Clear();
                u = 0;
            }

            public void Start()
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"Det her er {u}. opgave");
                Console.WriteLine();

                Console.ResetColor();
            }

            public void Fejl()
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("Fejl !");
                Console.ReadLine();

                Console.ResetColor();
                Console.Clear();
            }
        }

        static void Main(string[] args)
        {
            Pro menu1 = new Pro();
            Pro back1 = new Pro();
            Pro underMenu1 = new Pro();
            Pro slut1 = new Pro();
            Pro start1 = new Pro();
            Pro fejl1 = new Pro();

            string svar;

            while (i == 0) // Hovedemenu 0.0
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vaelg et Emne");
                Console.ResetColor();

                int a = 0;

                Console.WriteLine();
                foreach (string p in kategorier)
                {
                    a++;
                    Console.WriteLine($"{a}. {p}");
                }
                Console.WriteLine("L - lukker program");

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
                        fejl1.Fejl();
                    }
                }

                Console.Clear();

                while (i == 1) // Undermenu 1.0
                {
                    maxOpgaver = 6;

                    menu1.Menu();

                    underMenu1.UnderMenu();

                    back1.Back();

                    while (u == 1) // opgave 1.1
                    {
                        start1.Start();

                        int tal1;
                        int tal2;

                        tal1 = 5;
                        tal2 = 3;

                        Console.WriteLine(tal1);
                        Console.WriteLine(tal2);

                        slut1.Slut();
                    }

                    while (u == 2) // opgave 1.2
                    {
                        start1.Start();

                        int tal1;
                        int tal2;

                        tal1 = 5;
                        tal2 = 3;

                        Console.WriteLine(tal1);
                        Console.WriteLine(tal2);

                        Console.WriteLine();

                        Console.WriteLine($"Tal1 er {tal1}");
                        Console.WriteLine($"Tal2 er {tal2}");

                        slut1.Slut();
                    }

                    while (u == 3) // opgave 1.3
                    {
                        start1.Start();

                        string Navn = "Søren";
                        int Alder = 16;
                        double Penge = 1234.34;

                        Console.WriteLine($"Jeg hedder {Navn}, er {Alder} år gammel pg har tjent {Penge} kr. på at lappe cykler");

                        slut1.Slut();
                    }

                    while (u == 4) // opgave 1.4
                    {
                        start1.Start();

                        double Kage = 23.56;
                        double ol = 34.67;
                        double polse = 65.34;

                        Console.WriteLine($"Kage    {Kage}");
                        Console.WriteLine($"ol    {ol}");
                        Console.WriteLine($"polse     {polse}");

                        slut1.Slut();
                    }

                    while (u == 5) // opgave 1.5
                    {
                        start1.Start();

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

                        slut1.Slut();
                    }

                    while (u == 6) // opgave 1.6
                    {
                        start1.Start();

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

                        slut1.Slut();
                    }

                }

                while (i == 2) // Undermenu 2.0
                {
                    maxOpgaver = 4;
                    
                    menu1.Menu();

                    underMenu1.UnderMenu();

                    back1.Back();

                    while (u == 1) // opgave 2.1
                    {
                        start1.Start();

                        int tal = 4;
                        double kommaTal = 7.21;
                        string skrift = "Hej";

                        Console.WriteLine(tal);
                        Console.WriteLine(kommaTal);
                        Console.WriteLine(skrift);

                        slut1.Slut();
                    }

                    while (u == 2) // opgave 2.2
                    {
                        start1.Start();

                        int tal = 4;
                        double kommaTal = 7.21;
                        string skrift = "Hej";

                        tal = 2;
                        kommaTal = 9.52;
                        skrift = "Godag";

                        Console.WriteLine(tal);
                        Console.WriteLine(kommaTal);
                        Console.WriteLine(skrift);

                        slut1.Slut();
                    }

                    while (u == 3) // opgave 2.3
                    {
                        start1.Start();

                        string jul = "I dag har vi den 24. December.";

                        Console.WriteLine(jul);

                        slut1.Slut();
                    }

                    while (u == 4) // opgave 2.4
                    {
                        start1.Start();

                        double maengde = 200.50;
                        string ord = "Jeg har";
                        string ord2 = "kr. i banken";

                        Console.WriteLine($"{ord} {maengde}{ord2}");

                        slut1.Slut();
                    }

                }

                while (i == 3) // Undermenu 3.0
                {
                    maxOpgaver = 1;

                    menu1.Menu();

                    underMenu1.UnderMenu();

                    back1.Back();

                    while (u == 1) // opgave 3.1
                    {
                        start1.Start();

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

                        slut1.Slut();
                    }

                }

                while (i == 4) // Undermenu 4.0
                {
                    maxOpgaver = 2;
                    
                    menu1.Menu();

                    underMenu1.UnderMenu();

                    back1.Back();

                    while (u == 1) // opgave 4.1
                    {
                        start1.Start();

                        int tal1 = 4;
                        int tal2 = 13;
                        int tal3 = 21;
                        int result = 0;

                        Console.WriteLine($"tal1 = {tal1}");
                        Console.WriteLine($"tal2 = {tal2}");
                        Console.WriteLine($"tal3 = {tal3}");

                        result = tal1 + tal2 / tal3;

                        Console.WriteLine($"result = {result}");

                        slut1.Slut();
                    }

                    while (u == 2) // opgave 4.2
                    {
                        start1.Start();

                        int tal1 = 4;
                        double tal2 = 13.62;
                        int tal3 = 21;
                        double result = 0;

                        Console.WriteLine($"tal1 = {tal1}");
                        Console.WriteLine($"tal2 = {tal2}");
                        Console.WriteLine($"tal3 = {tal3}");

                        result = tal1 * 5 + tal2 / tal3 - 30;

                        Console.WriteLine($"result = {result}");

                        slut1.Slut();
                    }

                }

                while (i == 5) // Undermenu 5.0
                {
                    maxOpgaver = 1;
                    
                    menu1.Menu();

                    underMenu1.UnderMenu();

                    back1.Back();

                    while (u == 1) // opgave 5.1
                    {
                        start1.Start();

                        int var1 = 8;
                        int var2 = 15;

                        Console.WriteLine($"var1 = {var1}");
                        Console.WriteLine($"var2 = {var2}");

                        bool boolean = var1 > var2;

                        Console.WriteLine($"boolean = {boolean}");

                        slut1.Slut();
                    }

                }

                while (i == 6) // Undermenu 6.0
                {
                    maxOpgaver = 7;
                    
                    menu1.Menu();

                    underMenu1.UnderMenu();

                    back1.Back();

                    while (u == 1) // opgave 6.1
                    {
                        start1.Start();

                        int tal1 = 42;
                        int tal2 = 64;

                        Console.WriteLine($"tal1 = {tal1}");
                        Console.WriteLine($"tal2 = {tal2}");
                        Console.WriteLine();

                        int result = tal1 + tal2;

                        Console.WriteLine($"result = {result}");
                        Console.WriteLine();

                        if (result > 100)
                        {
                            Console.WriteLine("Summen er storer end 100");
                        }
                        else if (result < 100)
                        {
                            Console.WriteLine("Summen er mindre end 100");
                        }
                        else
                        {
                            Console.WriteLine("summen er lig med 100");
                        }

                        slut1.Slut();
                    }

                    while (u == 2) // opgave 6.2
                    {
                        start1.Start();

                        int alder = 0;

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Intast din alder");

                                alder = Convert.ToInt32(Console.ReadLine());

                                break;
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                alder = 0;

                                Console.WriteLine("Fejl !");
                                Console.ReadLine();

                                Console.Clear();
                            }
                        }

                        if (alder > 57)
                        {
                            Console.WriteLine("Du er for gammel.");
                        }
                        else
                        {
                            Console.WriteLine("Du er ikke for gammel.");
                        }

                        slut1.Slut();
                    }

                    while (u == 3) // opgave 6.3
                    {
                        start1.Start();

                        int alder;

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Intast din alder");

                                alder = Convert.ToInt32(Console.ReadLine());

                                break;
                            }
                            catch (Exception)
                            {
                                Console.Clear();

                                Console.WriteLine("Fejl !");
                                Console.ReadLine();

                                Console.Clear();
                            }
                        }

                        if (alder > 60)
                        {
                            Console.WriteLine("Du er for gammel.");
                        }
                        else if (alder > 50 && alder < 60)
                        {
                            Console.WriteLine("Du er hverken for gammel eller for ung.");
                        }
                        else
                        {
                            Console.WriteLine("Du er for ung.");
                        }

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 4) // opgave 6.4
                    {
                        start1.Start();

                        string navn = "Magnus";
                        string brug = "brugernavn";
                        string pass = "password";

                        string brugSvar;
                        string passSvar;

                        Console.WriteLine("Intast dit brugernavn");
                        brugSvar = Console.ReadLine();

                        Console.WriteLine("Intast dit password");
                        passSvar = Console.ReadLine();

                        if (brugSvar == brug && passSvar == pass)
                        {
                            Console.WriteLine($"Velkommen {navn}");
                        }
                        else
                        {
                            Console.WriteLine("Brugernavn eller Password er forkert.");
                        }

                        slut1.Slut();
                    }

                    while (u == 5) // opgave 6.5
                    {
                        start1.Start();

                        string navn = "Magnus";
                        string brug = "brugernavn";
                        string pass = "password";

                        string brugSvar;
                        string passSvar;

                        Console.WriteLine("Intast dit brugernavn");
                        brugSvar = Console.ReadLine();

                        if (brugSvar == brug)
                        {
                            Console.WriteLine("Intast dit password");
                            passSvar = Console.ReadLine();

                            if (passSvar == pass)
                            {
                                Console.WriteLine($"Velkommen {navn}");
                            }
                            else
                            {
                                Console.WriteLine("Password er forkert");
                            }
                        }
                        else
                        {
                            Console.WriteLine("brugernavn er forkert");
                        }

                        slut1.Slut();
                    }

                    while (u == 6) // opgave 6.6
                    {
                        start1.Start();

                        Console.WriteLine("Hvor mange km der køres hver dag til og fra arbejde?");

                        int km;

                        while (true)
                        {
                            try
                            {
                                km = Convert.ToInt32(Console.ReadLine());

                                break;
                            }
                            catch (Exception)
                            {
                                Console.Clear();

                                Console.WriteLine("Fejl !");
                                Console.ReadLine();

                                Console.Clear();
                            }
                        }

                        if (km <= 24)
                        {
                            Console.WriteLine("Du faar ikke fradrag.");
                        }
                        else if (km > 24 && km <= 120)
                        {
                            Console.WriteLine($"Du faar {(km - 24) * 1.93} kr. i fradrag");
                        }
                        else
                        {
                            Console.WriteLine($"Du faar {96 * 1.93 + (km - 120) * 0.97} kr. i fradrag");
                        }

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 7) // opgave 6.7
                    {
                        start1.Start();

                        string farve;
                        string alderString;
                        int alder;

                        Console.Title = "Festen";

                        Console.WriteLine($"Title: {Console.Title}");
                        Console.WriteLine();

                        Console.WriteLine("Hvilken farve foretrekker du?");

                        Console.WriteLine("\nRød\nGrøn\nBlå\nGul");
                        Console.WriteLine();

                        farve = Console.ReadLine();

                        while (true)
                        {
                            if (farve == "Rød" || farve == "rød")
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;

                                break;
                            }
                            else if (farve == "Grøn" || farve == "grøn")
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Black;

                                break;
                            }
                            else if (farve == "Blå" || farve == "blå")
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Black;

                                break;
                            }
                            else if (farve == "Gul" || farve == "gul")
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;

                                break;
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("Fejl !");
                                Console.ReadLine();

                                Console.Clear();
                            }
                        }

                        Console.WriteLine("Skriv din alder");

                        while (true)
                        {
                            try
                            {
                                alderString = Console.ReadLine();
                                alder = Convert.ToInt32(alderString);

                                break;
                            }
                            catch (Exception)
                            {
                                Console.Clear();

                                Console.WriteLine("Fejl !");
                                Console.ReadLine();

                                Console.Clear();
                            }
                        }

                        if (alder >= 18)
                        {
                            Console.WriteLine("Velkommen til cocktailbaren.");
                        }
                        else
                        {
                            Console.WriteLine("Velkommen til sodavandsbaren.");
                        }

                        Console.WriteLine("Vent 10 sek (skriv ikke noget)");
                        Thread.Sleep(10000);
                        Console.ResetColor();

                        Console.Clear();
                        u = 0;
                    }

                }

                while (i == 7) // Undermenu 7.0
                {
                    maxOpgaver = 2;
                    
                    menu1.Menu();

                    underMenu1.UnderMenu();

                    back1.Back();

                    while (u == 1) // opgave 7.1
                    {
                        start1.Start();

                        int caseSvar;

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Skriv et mellem 1 og 6.");

                                caseSvar = Convert.ToInt32(Console.ReadLine());

                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Fejl !");
                            }
                        }

                        switch (caseSvar)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 5:
                            case 6:
                                {
                                    Console.WriteLine($"Du har tastet {caseSvar}");

                                    break;
                                }
                            case 4:
                                {
                                    string tillykke = "TILLYKKE DU HAR VUNDET";

                                    Console.SetCursorPosition(Console.WindowWidth / 2 - tillykke.Length / 2, Console.WindowHeight / 2);

                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine(tillykke);

                                    Console.ResetColor();
                                    Console.WriteLine();

                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Du har tastet forkert.");
                                    Console.WriteLine("Vent 10 sek (Tast ikke noget)");
                                    Thread.Sleep(10000);

                                    break;
                                }
                        }

                        slut1.Slut();
                    }

                    while (u == 2) // opgave 7.2
                    {
                        start1.Start();

                        string valg;

                        Console.WriteLine("Velg en drink.");

                        Console.WriteLine("\n1. Isbjorn\n2. Champagnebrus\n3. Tequila Sunrise\n4. Mojito\n5. Brandbil\n6. Filur");

                        valg = Console.ReadLine();

                        double pris = 0;

                        switch (valg)
                        {
                            case "1":
                            case "isbjorn":
                            case "Isbjorn":
                                {
                                    pris = 49.99;

                                    break;
                                }
                            case "2":
                            case "champagnebrus":
                            case "Champagnebrus":
                                {
                                    pris = 54.99;

                                    break;
                                }
                            case "3":
                            case "tequila sunrise":
                            case "Tequila Sunrise":
                                {
                                    pris = 59.99;

                                    break;
                                }
                            case "4":
                            case "mojito":
                            case "Mojito":
                                {
                                    pris = 64.99;

                                    break;
                                }
                            case "5":
                            case "brandbil":
                            case "Brandbil":
                                {
                                    pris = 69.99;

                                    break;
                                }
                            case "6":
                            case "filur":
                            case "Filur":
                                {
                                    pris = 74.99;

                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Det er ikke et acceptabelt valg.");

                                    break;
                                }
                        }

                        Console.WriteLine($"Du har valgt {valg}, som koster {pris} kr.");

                        slut1.Slut();
                    }

                }

                while (i == 8) // undermenu 8.0
                {
                    maxOpgaver = 9;
                    
                    menu1.Menu();

                    underMenu1.UnderMenu();

                    back1.Back();

                    while (u == 1) // opgave 8.1
                    {
                        start1.Start();

                        for (int j = 1; j <= 10; j++)
                        {
                            Console.WriteLine($"for loop: {j}");
                        }

                        Console.WriteLine();

                        int n = 1;

                        while (n <= 10)
                        {
                            Console.WriteLine($"while loop {n}");
                            n++;
                        }

                        slut1.Slut();
                    }

                    while (u == 2) // opgave 8.2
                    {
                        start1.Start();

                        for (int j = 100; j > 0; j--)
                        {
                            Console.WriteLine($"for loop {j}");
                        }

                        int n = 100;

                        Console.WriteLine();

                        while (n > 0)
                        {
                            Console.WriteLine($"while loop {n}");
                            n--;
                        }

                        slut1.Slut();
                    }

                    while (u == 3) // opgave 8.3
                    {
                        start1.Start();

                        for (int j = 5; j <= 50; j += 5)
                        {
                            Console.WriteLine(j);
                        }

                        slut1.Slut();
                    }

                    while (u == 4) // opgave 8.4
                    {
                        start1.Start();

                        for (int j = 20; j >= 0; j--)
                        {
                            Console.WriteLine($"for loop {j}");
                        }

                        Console.WriteLine();

                        int n = 20;

                        while (n >= 0)
                        {
                            Console.WriteLine($"while loop {n}");
                            n--;
                        }

                        slut1.Slut();
                    }

                    while (u == 5) // opgave 8.5
                    {
                        start1.Start();

                        for (int j = 1; j * 7 <= 70; j++)
                        {
                            Console.WriteLine($"{j} * 7 = {j * 7}");
                        }

                        slut1.Slut();
                    }

                    while (u == 6) // opgave 8.6
                    {
                        start1.Start();

                        int k = 0;

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Velg en tabel (skriv et tal)");

                                k = Convert.ToInt32(Console.ReadLine());

                                break;
                            }
                            catch (Exception)
                            {
                                Console.Clear();

                                Console.WriteLine("Fejl !");

                                Console.ReadLine();
                                Console.Clear();
                            }
                        }

                        for (int j = 1; j * k <= k * 10; j++)
                        {
                            Console.WriteLine($"{j} * {k} = {j * k}");
                        }

                        slut1.Slut();
                    }

                    while (u == 7) // opgave 8.7
                    {
                        start1.Start();

                        int startPos1 = 20;
                        int startPos2 = 4;

                        int brede = 10;
                        int lengde = 4;

                        Console.SetCursorPosition(startPos1, startPos2);

                        for (int y = 1; y < brede; y++)
                        {
                            Console.SetCursorPosition(y + startPos1, startPos2);
                            Console.Write("\x2500");

                            Console.SetCursorPosition(y + startPos1, startPos2 + lengde);
                            Console.Write("\x2500");
                        }

                        for (int y = 1; y < lengde; y++)
                        {
                            Console.SetCursorPosition(startPos1, y + startPos2);
                            Console.Write("\x2502");

                            Console.SetCursorPosition(startPos1 + brede, y + startPos2);
                            Console.Write("\x2502");
                        }

                        Console.SetCursorPosition(startPos1, startPos2);
                        Console.Write("\x250C");

                        Console.SetCursorPosition(startPos1 + brede, startPos2);
                        Console.Write("\x2510");

                        Console.SetCursorPosition(startPos1, startPos2 + lengde);
                        Console.Write("\x2514");

                        Console.SetCursorPosition(startPos1 + brede, startPos2 + lengde);
                        Console.Write("\x2518");

                        Console.WriteLine();

                        Console.ReadLine();
                        Console.Clear();
                        u = 0;
                    }

                    while (u == 8) // opgave 8.8
                    {
                        start1.Start();

                        int startPos1 = 20;
                        int startPos2 = 4;

                        int brede = 10;
                        int lengde = 4;

                        string navn = "Magnus";

                        Console.SetCursorPosition(startPos1, startPos2);

                        for (int y = 1; y < brede; y++)
                        {
                            Console.SetCursorPosition(y + startPos1, startPos2);
                            Console.Write("\x2500");

                            Console.SetCursorPosition(y + startPos1, startPos2 + lengde);
                            Console.Write("\x2500");
                        }

                        for (int y = 1; y < lengde; y++)
                        {
                            Console.SetCursorPosition(startPos1, y + startPos2);
                            Console.Write("\x2502");

                            Console.SetCursorPosition(startPos1 + brede, y + startPos2);
                            Console.Write("\x2502");
                        }

                        Console.SetCursorPosition(startPos1, startPos2);
                        Console.Write("\x250C");

                        Console.SetCursorPosition(startPos1 + brede, startPos2);
                        Console.Write("\x2510");

                        Console.SetCursorPosition(startPos1, startPos2 + lengde);
                        Console.Write("\x2514");

                        Console.SetCursorPosition(startPos1 + brede, startPos2 + lengde);
                        Console.Write("\x2518");

                        Console.SetCursorPosition(startPos1 + brede / 2 - navn.Length / 2, startPos2 + lengde / 2);
                        Console.Write(navn);

                        Console.WriteLine();

                        slut1.Slut();
                    }

                    while (u == 9) // opgave 8.9
                    {
                        start1.Start();

                        int startPos1 = 20;
                        int startPos2 = 4;

                        int brede = 0;
                        int lengde = 0;

                        string navn;

                        Console.WriteLine("Intast dit fornavn");
                        navn = Console.ReadLine();

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Intast brede af rammen");
                                brede = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Intast lengde af rammen");
                                lengde = Convert.ToInt32(Console.ReadLine());

                                break;
                            }
                            catch (Exception)
                            {
                                Console.Clear();

                                Console.WriteLine("Fejl !");
                                Console.ReadLine();

                                Console.Clear();
                            }
                        }

                        Console.Clear();

                        Console.SetCursorPosition(startPos1, startPos2);

                        for (int y = 1; y < brede; y++)
                        {
                            Console.SetCursorPosition(y + startPos1, startPos2);
                            Console.Write("\x2500");

                            Console.SetCursorPosition(y + startPos1, startPos2 + lengde);
                            Console.Write("\x2500");
                        }

                        for (int y = 1; y < lengde; y++)
                        {
                            Console.SetCursorPosition(startPos1, y + startPos2);
                            Console.Write("\x2502");

                            Console.SetCursorPosition(startPos1 + brede, y + startPos2);
                            Console.Write("\x2502");
                        }

                        Console.SetCursorPosition(startPos1, startPos2);
                        Console.Write("\x250C");

                        Console.SetCursorPosition(startPos1 + brede, startPos2);
                        Console.Write("\x2510");

                        Console.SetCursorPosition(startPos1, startPos2 + lengde);
                        Console.Write("\x2514");

                        Console.SetCursorPosition(startPos1 + brede, startPos2 + lengde);
                        Console.Write("\x2518");

                        Console.SetCursorPosition(startPos1 + brede / 2 - navn.Length / 2, startPos2 + lengde / 2);
                        Console.Write(navn);

                        Console.WriteLine();

                        slut1.Slut();
                    }

                }

                while (i == 9) // Undermenu 9.0
                {
                    maxOpgaver = 5;
                    
                    menu1.Menu();

                    underMenu1.UnderMenu();

                    back1.Back();

                    while (u == 1) // opgave 9.1
                    {
                        start1.Start();

                        Console.WriteLine("Udskriver 3 tabelen");
                        Console.WriteLine();

                        for (int j = 3; j <= 21; j += 3)
                        {
                            Console.WriteLine(j);
                        }

                        Console.WriteLine();
                        Console.WriteLine("Loopet er nu stoppet");

                        slut1.Slut();
                    }

                    while (u == 2) // opgave 9.2
                    {
                        start1.Start();

                        int n = 0;

                        Console.WriteLine("Den printer alle tal i 4 tabellen udover 16.");
                        Console.WriteLine();

                        while (true)
                        {
                            n += 4;

                            if (n == 16)
                            {
                                continue;
                            }
                            else if (n <= 40)
                            {
                                Console.WriteLine(n);
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Loopet er nu stoppet.");

                                break;
                            }
                        }

                        slut1.Slut();
                    }

                    while (u == 3) // opgave 9.3
                    {
                        start1.Start();

                        double km;
                        double fradrag;

                        Console.WriteLine("Dette program udregner befordringsfradrag");
                        Console.WriteLine();

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Hvor mange km har du i transport Pr. dag.");
                                Console.WriteLine();

                                km = Convert.ToDouble(Console.ReadLine());

                                break;
                            }
                            catch (Exception)
                            {
                                fejl1.Fejl();
                            }
                        }

                        while (true)
                        {
                            if (km < 24 || km == 24)
                            {
                                fradrag = 0;

                                Console.WriteLine($"Du har et fradrag på {fradrag} kr.");

                                break;
                            }
                            else if (km >= 25 && km <= 100)
                            {
                                fradrag = (km - 24) * 1.54;

                                Console.WriteLine($"Du har et fradrag på {fradrag} kr.");

                                break;
                            }
                            else
                            {
                                fradrag = (km - 100) + 76 * 1.54 + km * 0.77;
                                
                                Console.WriteLine($"Du har et fradrag på {fradrag} kr.");

                                break;
                            }
                        }

                        slut1.Slut();
                    }
                    
                    while (u == 4) // opgave 9.4
                    {
                        start1.Start();

                        double indkomst;
                        double bundskat = 0;
                        double mellemskat = 0;
                        double topskat = 0;

                        Console.WriteLine("Det her program viser, hvor meget du skal betale i skat.");
                        Console.WriteLine();

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Hvor meget har du haft i indkomst i aar?");
                                Console.WriteLine();

                                indkomst = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();

                                break;
                            }
                            catch (Exception)
                            {
                                fejl1.Fejl();
                            }
                        }

                        if (indkomst < 42000 || indkomst == 42000)
                        {
                            Console.WriteLine("Du skal ikke betale skat.");
                        }
                        else if (indkomst > 42000 && indkomst < 280000)
                        {
                            bundskat = (indkomst - 42000) / 100 * 30;   

                            Console.WriteLine($"Bundskat 30% = {bundskat} kr.");
                        }
                        else if (indkomst < 390000)
                        {
                            bundskat = 238000 / 100 * 30;
                            mellemskat = (indkomst - 280000) / 100 * 36;

                            Console.WriteLine($"Bundskat 30% = {bundskat} kr.");
                            Console.WriteLine($"Mellemskat 6% = {mellemskat} kr.");
                        }
                        else if (indkomst > 390000 || indkomst == 390000)
                        {
                            bundskat = 238000 / 100 * 30;
                            mellemskat = 110000 / 100 * 36;
                            topskat = (indkomst - 390000) / 100 * 51;

                            Console.WriteLine($"Bundskat 30% = {bundskat} kr.");
                            Console.WriteLine($"Mellemskat 6% = {mellemskat} kr.");
                            Console.WriteLine($"Topskat 15% = {topskat} kr.");
                        }

                        Console.WriteLine($"I Alt {bundskat + mellemskat + topskat} kr.");

                        slut1.Slut();
                    }

                    while (u == 5) // opgave 9.5
                    {
                        start1.Start();

                        double penge = 0;

                        Console.WriteLine("Dette program udregner, hvor meget du faar i rente paa et aar.");
                        Console.WriteLine();

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Hvor mange penge har du paa din konto?");
                                Console.WriteLine();

                                penge = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();

                                break;
                            }
                            catch (Exception)
                            {
                                fejl1.Fejl();
                            }
                        }

                        if (penge < 25000 || penge == 25000)
                        {
                            Console.WriteLine($"Du har { penge * 0.25 / 100 } kr. efter et aar.");
                        }
                        else if (penge > 25000 && penge <= 150000)
                        {
                            Console.WriteLine($"Du har { penge * 1.25 / 100 } kr. efter et aar.");
                        }
                        else if (penge > 150000 || penge == 150000)
                        {
                            Console.WriteLine($"Du har { (150000 * 1.25 / 100) + (penge - 150000) * 0.5 / 100 } kr. efter et aar.");
                        }
                        else
                        {
                            fejl1.Fejl();
                        }

                        slut1.Slut();
                    }
                    
                }

                while (i == 10) // Undermenu 10.0
                {
                    maxOpgaver = 2;

                    menu1.Menu();

                    underMenu1.UnderMenu();

                    back1.Back();

                    while (u == 1) // opgave 10.1
                    {
                        start1.Start();

                        Bog SherlockHolmes = new Bog();

                        SherlockHolmes.PrintInfo();

                        slut1.Slut();
                    }

                    while (u == 2) // opgave 10.2
                    {
                        start1.Start();

                        Bog SherlockHolmes = new Bog();

                        SherlockHolmes.HarRaad();

                        slut1.Slut();
                    }

                }

            }

        }

    }
}
