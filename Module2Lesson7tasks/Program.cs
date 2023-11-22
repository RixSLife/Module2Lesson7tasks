using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module2Lesson7tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie nr 1
            //Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
            //Dane testowe:
            //a: 5
            //b: 5
            //Rezultat w terminalu:
            //5 i 5 są równe
            Console.WriteLine("Zadanie nr1");
            Console.WriteLine("");
            Console.WriteLine("Czy chcesz sprawdzic czy \"A\" jest rowne \"B\"??? (Y/N)");
            string iWant = Console.ReadLine();
            iWant = iWant.ToUpper();
            Console.WriteLine("");

            if (iWant == "Y")
            {
                Console.WriteLine("Podaj liczbe A: ");
                double a1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj liczbe B;");
                double b1 = Convert.ToDouble(Console.ReadLine());

                if (a1 == b1)
                {
                    Console.WriteLine("Tak, wartosc A i B sa sobie rowne.");

                }
                else
                {
                    Console.WriteLine("Nie, wartosc A i B sie roznia.");
                }
            }
            else
            {
                Console.WriteLine("OK. przejdz do nastepnego zadania.");
            }

            //Zadanie nr 2
            //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
            //Dane testowe : 15
            //Rezultat w terminalu:
            //15 jest liczbą nieparzystą
            Console.WriteLine("\n");
            Console.WriteLine("Zadanie nr 2 \n");
            Console.WriteLine("Podaj liczbe aby sprawdzic czy jest liczba przysta czy nieparzysta.");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = (x % 2);
            if (x == 0)
            {
                Console.WriteLine("Liczba 0 jest uznawana jako liczba parzysta w arytmetyce.");
            }
            else
            {
                if (y == 0)
                {
                    Console.WriteLine("Liczba " + x + " jest liczba parzysta.");
                }
                else
                {
                    Console.WriteLine("Liczba " + x + " jest liczba nieparzysta.");
                }
            }

            //Zadanie nr 3
            //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
            //Dane testowe : 14
            //Rezultat w terminalu:
            //14 jest liczbą dodatnią
            Console.WriteLine("\n");
            Console.WriteLine("Zadanie nr 3 \n");
            Console.WriteLine("Podaj liczbe aby sprawdzic czy liczba jest ujemna czy dodatnia");
            double w = double.Parse(Console.ReadLine());

            if (w > 0)
            {
                Console.WriteLine("Liczba " + w + "jest liczba dodatnia.");
            }
            else if (w == 0)
            {
                Console.WriteLine("Zero nie jest ani dodatnie, ani ujemne.");
            }
            else
            {
                Console.WriteLine("Liczba " + w + "Jest liczba ujemna");
            }

            //Zadanie nr 4
            //Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
            //Dane testowe : 2016
            //Rezultat w terminalu:
            //2016 jest rokiem przestępnym
            Console.WriteLine("\n");
            Console.WriteLine("Zadanie nr 4 \n");
            Console.WriteLine("Podaj ROK aby sprawdzic czy jest/byl rokiem przestepnym.");
            double r = double.Parse(Console.ReadLine());

            double rr = (r % 4);

            if (rr == 0)
            {
                Console.WriteLine("Tak, to rok przestepny.");
            }
            else
            {
                Console.WriteLine("Nie, to nie jest rok przestepny");
            }

            //Zadanie nr 5
            //Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,prezydenta.
            //Dane testowe : 21
            //Rezultat w terminalu:
            //Możesz zostać posłem
            Console.WriteLine("\n");
            Console.WriteLine("Zadanie nr 5 \n");
            Console.WriteLine("Podaj wiek aby sprawdzic czy mozesz ubiegac sie o stanowisko");
            Console.WriteLine("posla, premiera senatora lub prezydenta.");
            double age = double.Parse(Console.ReadLine());
            //posel min 21
            //premier min 21
            //senator min 21
            //prezydent min 35
            if (age >= 21 && age <= 34)
            {
                Console.WriteLine("Mozesz ubiegac sie o stanowisko posla, premiera, senatora lecz nie prezydenta.");
            }
            else if (age < 21)
            {
                Console.WriteLine("Jestes zbyt mlody by ubiegac sie o stanowisko w rzadzie.");
            }
            else
            {
                Console.WriteLine("Mozesz ubiegac sie o stanowisko posla, premiera, senatora i prezydenta.");
            }

            //Zadanie nr 6
            //Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
            //Dane testowe : 140
            //Rezultat w terminalu:
            //Jesteś krasnoludem
            Console.WriteLine("Zadanie nr 6 \n");
            Console.WriteLine("Podaj swoj wzrost: (cm)");
            double wz;
            if (double.TryParse(Console.ReadLine(), out wz))
            {
                if (wz <= 140)
                {
                    Console.WriteLine("Jestes krasnoludem.");
                }
                else if (wz > 140 && wz < 180)
                {
                    Console.WriteLine("Prawie jak facet...");
                }
                else if (wz >= 180 && wz < 200)
                {
                    Console.WriteLine("No i to jest facet.");
                }
                else
                {
                    Console.WriteLine("Gortat to ktos z rodziny?");
                }
            }
            else
            {
                Console.WriteLine("Niepoprawny format danych..");
            }

            //Zadanie nr 7
            //Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
            //Dane testowe:
            //25
            //63
            //79
            //Rezultat w terminalu:
            //79 jest największa z podanych
            Console.WriteLine("\n");
            Console.WriteLine("Zadanie nr 7 \n");
            Console.WriteLine("Podaj liczy do sprawdzenia ktora z nich jest najwieksza:\n");
            Console.WriteLine("Podaj pierwsza liczbe : ");
            string liczba1input = Console.ReadLine();
            double liczba1;
            double.TryParse(liczba1input, out liczba1);
            Console.WriteLine("Podaj druga liczbe: ");
            string liczba2input = Console.ReadLine();
            double liczba2;
            double.TryParse(liczba2input, out liczba2);
            Console.WriteLine("Podaj trzecia liczbe: ");
            string liczba3input = Console.ReadLine();
            double liczba3;
            double.TryParse(liczba3input, out liczba3);

            double liczMax = Math.Max(Math.Max(liczba1, liczba2), liczba3);
            Console.WriteLine("Najwieksza z liczb jest: " + liczMax);

            //Zadanie nr 7 ver 2 "IFowa"
            Console.WriteLine("\n");
            Console.WriteLine("Zadanie nr 7 ver 2 \n");
            Console.WriteLine("Podaj liczy do sprawdzenia ktora z nich jest najwieksza:\n");
            Console.WriteLine("Podaj pierwsza liczbe : ");
            string liczba1ainput = Console.ReadLine();
            double liczba1a;
            double.TryParse(liczba1ainput, out liczba1a);
            Console.WriteLine("Podaj druga liczbe: ");
            string liczba2ainput = Console.ReadLine();
            double liczba2a;
            double.TryParse(liczba2ainput, out liczba2a);
            Console.WriteLine("Podaj trzecia liczbe: ");
            string liczba3ainput = Console.ReadLine();
            double liczba3a;
            double.TryParse(liczba3ainput, out liczba3a);

            if (liczba1a > liczba2a)
            {
                if (liczba1a > liczba3a)
                {
                    Console.WriteLine(liczba1a + " jest liczba najwieksza.");
                }
                else
                {
                    Console.WriteLine(liczba3a + " jest liczba najwieksza.");
                }
            }
            else
            {
                if (liczba2a > liczba3a)
                {
                    Console.WriteLine(liczba2a + " jest liczba najwieksza.");
                }
                else
                {
                    Console.WriteLine(liczba3a + " jest liczba najwieksza.");
                }
            }

            //Zadanie nr 8
            //Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg.Następujących kryteriów:
            //Wynik z Matury z matematyki powyżej 70
            //Wynik z fizyki powyżej 55
            //Wynik z chemii powyżej 45
            //Łączny wynik z 3 przedmiotów powyżej 180
            //Albo
            //Wynik z matematyki i jednego przedmiotu powyżej 150
            //Dane testowe:
            //Matematyka 80
            //Fizyka 71
            //Chemia 0
            //Rezultat w terminalu:
            //Kandydat dopuszczony do rekrutacji
            Console.WriteLine("Zadanie nr 8\n");
            Console.WriteLine("Podaj wyniki z matury aby sprawdzic czy mozesz ubiegac sie o miejsce na studiach.");
            Console.WriteLine("Podaj wynik matury z MATEMATYKI:");
            double mat;
            if (double.TryParse(Console.ReadLine(), out mat))
            {
                Console.WriteLine("Podaj wynik matury z FIZYKI:");
                double fiz;
                if (double.TryParse(Console.ReadLine(), out fiz))
                {
                    if (mat + fiz > 150)
                    {
                        Console.WriteLine("Kwalifikujesz sie do miejsca na studiach.");
                    }
                    else
                    {
                        Console.WriteLine("Podaj wynik matury z CHEMII");
                        double chem;
                        if (double.TryParse(Console.ReadLine(), out chem))
                        {
                            if ((mat + chem) > 150 || (mat + fiz + chem) > 180 || (mat > 70 && fiz > 55 && chem > 45))
                            {
                                Console.WriteLine("Kwalifikujesz sie do miejsca na studiach.");
                            }
                            else
                            {
                                Console.WriteLine("Niestety nie kwalifikujesz sie na studia.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Niewlasciwy format danych!!!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Niewlasciwy format danych!!!");
                }
            }
            else
            {
                Console.WriteLine("Niewlasciwy format danych!!!");
            }

            //Zadanie nr 9
            //Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
            //Temp < 0 – cholernie piździ
            //Temp 0 – 10 – zimno
            //Temp 10 – 20 – chłodno
            //Temp 20 – 30 – w sam raz
            //Temp 30 – 40 – zaczyna być słabo, bo gorąco
            //Temp >= 40 – a weź wyprowadzam się na Alaskę.
            //Dane testowe : 41
            //Rezultat w terminalu:
            //a weź wyprowadzam się na Alaskę.
            Console.WriteLine("\n");
            Console.WriteLine("Zadanie nr 9\n");
            Console.WriteLine("Podaj temperature: ('C)");
            double temp;
            if (double.TryParse(Console.ReadLine(), out temp))
            {
                if (temp < 0)
                {
                    Console.WriteLine("Cholernie pizdzi.");
                }
                else if (temp >= 0 && temp < 10)
                {
                    Console.WriteLine("Zimno.");
                }
                else if (temp >= 10 && temp < 20)
                {
                    Console.WriteLine("Chlodno.");
                }
                else if (temp >= 20 && temp < 30)
                {
                    Console.WriteLine("W sam raz.");
                }
                else if (temp >= 30 && temp < 40)
                {
                    Console.WriteLine("Zaczyna byc slabo, bo goraco.");
                }
                else
                {
                    Console.WriteLine("...a wez wyprowadzam sie na Alaske.");
                }
            }
            else
            {
                Console.WriteLine("Niewlasciwy format danych.");
            }

            //Zadanie10
            //Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt
            //Dane testowe : 40 55 65
            //Rezultat w terminalu:
            //Można zbudować trójkąt
            // Mozna zbudowac gdy suma dwoch bokow wynosi wiecej niz trzeci (najdluszy)
            Console.WriteLine("\n");
            Console.WriteLine("Zadanie nr 10\n");
            Console.WriteLine("Podaj trzy dlugosci do stworzenia trojkata:");
            Console.WriteLine("Dlugosc \"A\":");
            string inpA = Console.ReadLine();
            double a;
            double.TryParse(inpA, out a);
            Console.WriteLine("Dlugosc \"B\":");
            string inpB = Console.ReadLine();
            double b;
            double.TryParse(inpB, out b);
            Console.WriteLine("Dlugosc \"C\":");
            string inpC = Console.ReadLine();
            double c;
            double.TryParse(inpC, out c);

            if (a >= b)
            {
                if (a >= c)
                {
                    if ((b + c) > a)
                    {
                        Console.WriteLine("Z tych dlugosci mozna stworzyc trojkat.");
                    }
                    else { Console.WriteLine("Niestety z tych dlugosci nie mozna stworzyc trojkata."); }
                }
                else
                {
                    if ((a + b) > c)
                    {
                        Console.WriteLine("Z tych dlugosci mozna stworzyc trojkat.");
                    }
                    else { Console.WriteLine("Niestety z tych dlugosci nie mozna stworzyc trojkata."); }
                }
            }
            else
            {
                if ((a + c) > b)
                {
                    Console.WriteLine("Z tych dlugosci mozna stworzyc trojkat.");
                }
                else { Console.WriteLine("Niestety z tych dlugosci nie mozna stworzyc trojkata."); }
            }

            //Zadanie nr 11
            //Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
            //Ocena Opis
            //6 Celujący
            //5 Bardzo dobry
            //4 Dobry
            //3 Dostateczny
            //2 Dopuszczający
            //1 Niedostateczny
            //Dane testowe : 3
            //Rezultat w terminalu:
            //Dostateczny
            Console.WriteLine("Zadanie nr 11 \n");
            Console.WriteLine("Podaj ocene by otrzymac jej opis:");
            string userInput = Console.ReadLine();
            int ocena;
            int.TryParse(userInput, out ocena);
            if (ocena == 6)
            {
                Console.WriteLine("Celujacy");
            }
            else if (ocena == 5)
            {
                Console.WriteLine("Bardzo dobry");
            }
            else if (ocena == 4)
            {
                Console.WriteLine("Dobry");
            }
            else if (ocena == 3)
            {
                Console.WriteLine("Dostateczny");
            }
            else if (ocena == 2)
            {
                Console.WriteLine("Dopuszczajacy");
            }
            else if (ocena == 1)
            {
                Console.WriteLine("Niedostateczny");
            }
            else
            {
                Console.WriteLine("Niewlasciwy format danych.");
            }

            //Zadanie nr 12
            //Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
            //Dane testowe: 4
            //Rezultat w terminalu:
            //Czwartek
            Console.WriteLine("\n");
            Console.WriteLine("Zadanie nr 12 \n");
            Console.WriteLine("Podaj nr dnia tygodnia:");
            string usInput = Console.ReadLine();
            int dzien;
            int.TryParse(usInput, out dzien);
            if (dzien == 7)
            {
                Console.WriteLine("Niedziela");
            }
            else if (dzien == 6)
            {
                Console.WriteLine("Sobota");
            }
            else if (dzien == 5)
            {
                Console.WriteLine("Piatek");
            }
            else if (dzien == 4)
            {
                Console.WriteLine("Czawartek");
            }
            else if (dzien == 3)
            {
                Console.WriteLine("Sroda");
            }
            else if (dzien == 2)
            {
                Console.WriteLine("Wtorek");
            }
            else if (dzien == 1)
            {
                Console.WriteLine("Poniedzialek");
            }
            else
            {
                Console.WriteLine("Niewlasciwy format danych.");
            }

            //Zadanie nr 13
            //Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem
            //Podaj pierwszą liczbę:
            //…
            //Podaj drugą liczbę:
            //…
            //Podaj numer operacji do wykonania:
            //1.Dodawanie
            //2.Odejmowanie
            //3.Mnożenie
            //4.Dzielenie
            //…
            //Twój wynik to
            Console.WriteLine("\n");
            Console.WriteLine("Zadanie nr 13 \n");
            Console.WriteLine("Podaj pierwsza liczbe:");
            string inputA = Console.ReadLine();
            double aa;
            double.TryParse(inputA, out aa);
            Console.WriteLine("Podaj druga liczbe:");
            string inputB = Console.ReadLine();
            double bb;
            double.TryParse(inputB, out bb);
            Console.WriteLine("Podaj rodzaj dzialania:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnozenie");
            Console.WriteLine("4. Dzielenie");
            string inputC = Console.ReadLine();
            double dzial;
            double.TryParse(inputC, out dzial);
            Console.WriteLine("Twoj wynik to:");
            if (dzial == 1)
            {
                double dod = aa + bb;
                Console.WriteLine($"{aa} + {bb} = {dod}");
            }
            else if (dzial == 2)
            {
                double ode = aa - bb;
                Console.WriteLine($"{aa} - {bb} = {ode}");
            }
            else if (dzial == 3)
            {
                double mnoz = aa * bb;
                Console.WriteLine($"{aa} * {bb} = {mnoz}");
            }
            else if (dzial == 4)
            {
                double dzie = aa / bb;
                Console.WriteLine($"{aa} / {bb} = {dzie}");
            }
            else
            {
                Console.WriteLine("Niewlasciwy format danych!");
            }
            Console.ReadKey();
        }
    }
}
