// See https://aka.ms/new-console-template for more information
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
    if (!int.TryParse(Console.ReadLine(), out int exercise))
    {
        Console.Clear();
        Console.WriteLine("Nie rozpoznano numeru ćwiczenia. Podaj numer ponownie...\n");
        continue;
    }
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
                    for (int j = 2; j < i; j++)
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
                Console.Write("Podaj ilość wyrazów ciągu, które chcesz uzyskać: ");
                _ = int.TryParse(Console.ReadLine(), out int quantity);
                int first = 0, second = 1;
                for(int n = 0; n < quantity; n++)
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
                break;
            }
        case 5:
            //5.Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            {
                break;
            }
        case 6:
            //6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            //1 + 1/2 + 1/3 + 1/4 itd.
            {
                break;
            }
        case 7:
            //7.Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
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
                break;
            }
        case 8:
            //8.Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
            //Testowe dane:
            //Abcdefg
            //Rezultat
            //Gfedcba
            {
                break;
            }
        case 9:
            //9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
            {
                break;
            }
        case 10:
            //10. Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
            {
                break;
            }
        default:
            {
                Console.WriteLine("Nie rozpoznano numeru ćwiczenia. Podaj numer ponownie...\n");
                continue;
            }
    }

    Console.Write("\n\nWciśnij Enter aby wrócić do menu...");
    Console.ReadKey();
    Console.Clear();
}