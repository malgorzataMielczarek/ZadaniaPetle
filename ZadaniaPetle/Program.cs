// See https://aka.ms/new-console-template for more information
using System.Text;

bool run = true;
while (run)
{
    Console.WriteLine("0. Zakończ działanie programu.");
    Console.WriteLine("1. Liczby pierwsze");
    Console.WriteLine("2. Liczby parzyste");
    Console.WriteLine("3. Ciąg Fibonacciego");
    Console.WriteLine("4. Piramida");
    Console.WriteLine("5. Sześcian liczby");
    Console.WriteLine("6. Suma ułamków");
    Console.WriteLine("7. Diament");
    Console.WriteLine("8. Wspak");
    Console.WriteLine("9. Liczba binarna");
    Console.WriteLine("10. Najmniejsza wspólna wielokrotność");

    Console.Write("\nPodaj numer ćwiczenia, które chcesz wykonać: ");

    if (!int.TryParse(Console.ReadLine(), out int exercise)) exercise = -1;

    Console.Clear();

    switch (exercise)
    {

        case 0:
            {
                Console.WriteLine("\n----------PROGRAM ZAKOŃCZONY----------\n");
                run = false;
                continue;
            }

        case 1:
            //1. Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
            {
                Console.WriteLine("1. Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.\n");
                int numberOfPrimaries = 0;
                for (int i = 2; i <= 100; i++)
                {
                    bool primary = true;
                    for (int j = 2; j <= i/j; j++)
                    {
                        if (i % j == 0)
                        {
                            primary = false;
                            break;
                        }
                    }
                    if (primary)
                    {
                        numberOfPrimaries++;
                        Console.Write($" {i}");
                    }
                }
                Console.WriteLine("\nLiczb pierwszych w zakresie 0 - 100 jest: {0}", numberOfPrimaries);
                break;
            }

        case 2:
            //2. Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.
            {
                Console.WriteLine("2. Napisz program, w którym za pomocą pętli do...while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.\n");
                int even = 0;
                do
                {
                    Console.Write(" {0} ", even);
                    even += 2;
                }
                while (even <= 1000);
                Console.WriteLine();
                break;
            }

        case 3:
            //3. Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
            {
                Console.WriteLine("3. Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.\n");
                Console.Write("   Podaj ilość wyrazów ciągu, które chcesz uzyskać: ");
                _ = int.TryParse(Console.ReadLine(), out int quantity);
                int first = 0, second = 1;
                for (int n = 0; n < quantity; n++)
                {
                    if (n == 0) Console.Write(" 0 ");
                    else if (n == 1) Console.Write(" 1 ");
                    else
                    {
                        int number = first + second;
                        first = second;
                        second = number;
                        Console.Write(" {0} ", number);
                    }
                }
                Console.WriteLine();
                break;
            }

        case 4:
            //4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
            //1
            //2 3
            //4 5 6
            //7 8 9 10
            {
                Console.WriteLine("4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby.\n");
                Console.Write("   Podaj liczbę: ");
                if (int.TryParse(Console.ReadLine(), out int maxNumber))
                {
                    Console.Write("\t");
                    int row = 1;
                    for (int n = 1, c = 1; n <= maxNumber; n++, c++)
                    {
                        Console.Write($" {n} ");
                        if (c == row)
                        {
                            Console.Write("\n\t");
                            row++;
                            c = 0;
                        }
                    }
                    Console.WriteLine();
                }
                else Console.WriteLine("   Nie udało się odczytać podanej liczby.");
                break;
            }

        case 5:
            //5.Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            {
                Console.WriteLine("5. Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.\n");
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine($"\t{i}\t->\t{i * i * i}");
                }
                break;
            }

        case 6:
            //6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            //1 + 1/2 + 1/3 + 1/4 itd.
            {
                Console.WriteLine("6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + 1/2 + 1/3 + 1/4 itd.\n");
                decimal sum = 0;
                for (int i = 0; i <= 20; i++)
                {
                    if (i != 0)
                    {
                        Console.Write($"1/{i}");
                        sum += 1M / i;
                        if (i != 20) Console.Write(" + ");
                        else Console.WriteLine(" = {0}", sum);
                    }
                }
                break;
            }

        case 7:
            //7. Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
            //    *
            //   ***
            //  *****
            // *******
            //*********
            // *******
            //  *****
            //   ***
            //    *
            {
                Console.WriteLine("7. Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika.\n");
                Console.Write("   Podaj długość krótszej przekątnej: ");
                if (int.TryParse(Console.ReadLine(), out int diagonal))
                {
                    int spaces = diagonal / 2;
                    int stars = diagonal % 2;
                    for (; stars < diagonal; spaces -= 1, stars += 2)
                    {
                        Console.Write("\n\t");
                        for (int i = 0; i < spaces; i++) Console.Write("  ");
                        for (int i = 0; i < stars; i++) Console.Write("* ");
                    }
                    for (; stars > 0; spaces += 1, stars -= 2)
                    {
                        Console.Write("\n\t");
                        for (int i = 0; i < spaces; i++) Console.Write("  ");
                        for (int i = 0; i < stars; i++) Console.Write("* ");
                    }
                }
                else Console.WriteLine("   Nie udało się odczytać długości przekątnej.");
                break;
            }

        case 8:
            //8. Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
            //Testowe dane:
            //Abcdefg
            //Rezultat
            //Gfedcba
            {
                Console.WriteLine("8. Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.\n");
                
                Console.WriteLine("   Np.:");
                string? text = "Abcdefg";
                Console.WriteLine("\tWprowadzony ciąg znaków: {0}", text);

                StringBuilder reverse = new StringBuilder();
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    char c = text[i];
                    if (reverse.Length > 0) c = char.ToLower(c);
                    else c = char.ToUpper(c);
                    reverse.Append(c);
                }

                Console.WriteLine("\tWynik: {0}", reverse);


                Console.Write("\n   Podaj ciąg znaków: ");
                text = Console.ReadLine();

                reverse.Clear();
                if (text != null)
                {
                    for (int i = text.Length - 1; i >= 0; i--)
                    {
                        char c = text[i];
                        if (reverse.Length > 0) c = char.ToLower(c);
                        else c = char.ToUpper(c);
                        reverse.Append(c);
                    }
                }

                Console.WriteLine("   Wynik: {0}", reverse);
                break;
            }

        case 9:
            //9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
            {
                Console.WriteLine("9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.\n");
                
                Console.Write("   Podaj dodatnią liczbę całkowitą w zapisie dziesiętnym: ");
               
                if (int.TryParse(Console.ReadLine(), out int dec) && dec >= 0)
                {
                    int remainder = dec;
                    string bin = "";
                    if (dec == 0) bin = "0";
                    while (remainder > 0)
                    {
                        bin = remainder % 2 + bin;
                        remainder /= 2;
                    }

                    Console.WriteLine("   Liczba {0} w zapisie binarnym: {1}", dec, bin);
                }
                else Console.WriteLine("   Nie udało się odczytać podanej liczby.");
                break;
            }

        case 10:
            //10. Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
            {
                Console.WriteLine("10. Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.\n");
                
                Console.Write("   Pierwsza liczba: ");
                bool success = int.TryParse(Console.ReadLine(), out int firstNumber);
               
                Console.Write("   Druga liczba: ");
                success &= int.TryParse(Console.ReadLine(), out int secondNumber);
                
                if (success)
                {
                    if (firstNumber <= 0 || secondNumber <= 0)
                    {
                        Console.WriteLine("   Podane liczby muszą być większe od zera.");
                        break;
                    }

                    int lcm = 1;
                    int firstRemainder = firstNumber;
                    int secondRemainder = secondNumber;
                    int minNumber;

                    if (firstNumber < secondNumber) minNumber = firstNumber;
                    else minNumber = secondNumber;

                    for (int i = 2; i < minNumber; i++)
                    {
                        while (firstRemainder % i == 0 || secondRemainder % i == 0)
                        {
                            lcm *= i;
                            if (firstRemainder % i == 0) firstRemainder /= i;
                            if (secondRemainder % i == 0) secondRemainder /= i;
                        }

                        if (firstRemainder == 1 || secondRemainder == 1) break;
                    }

                    lcm *= firstRemainder * secondRemainder;
                    Console.WriteLine("   NWW: " + lcm);
                }
                else Console.WriteLine("   Nie udało się odczytać podanych liczb.");
                break;
            }

        default:
            {
                Console.WriteLine("   Nie rozpoznano numeru ćwiczenia. Podaj numer ponownie...\n");
                continue;
            }
    }

    Console.Write("\n\nWciśnij Enter aby wrócić do menu...");
    Console.ReadKey();
    Console.Clear();
}