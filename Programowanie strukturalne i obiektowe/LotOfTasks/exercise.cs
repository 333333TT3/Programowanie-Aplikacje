using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class Exercise
    {
        public void Exercise1()
        {
            int x = 14;
            int y = 23;
            var suma = (x + y) / 2;
            Console.WriteLine("Srednia dwoch podanych liczb to: ");
            Console.WriteLine(suma);
        }

        public void Exercise2()
        {
            int a = 14;
            int b = 41;
            var obwod = (a * b);
            Console.WriteLine("Obwod prostokata to: ");
            Console.WriteLine(obwod);
        }

        public void Exercise3()
        {
            int h = 53;
            int r = 3;
            var dwa = r * r;
            var objetosc = (Math.PI * dwa * h);
            Console.WriteLine("Objetosc stozka to: ");
            Console.WriteLine(objetosc);

        }

        public void Exercise4()
        {
            int r = 26;
            var dwa = r * r;
            var pole = (Math.PI * dwa);
            Console.WriteLine("Pole kola to: ");
            Console.WriteLine(pole);
        }

        public void Exercise5()
        {
            int a = 6;
            int b = 4;
            var first = a * a;
            var second = b * b;
            var equation = (first + second);
            Console.WriteLine("Wynik to: ");
            Console.WriteLine(equation);
        }

        public void Exercise6()
        {
            int b = 6;
            int h = 3;
            var first = b / 2;
            var equation = (first * h);
            Console.WriteLine("Pole trojkata to: ");
            Console.WriteLine(equation);
        }

        public void Exercise7()
        {
            int r = 5;
            var first = Math.PI * 4;
            var second = r * 2;
            var equation = first * second;
            Console.WriteLine("Objetosc kuli to: ");
            Console.WriteLine(equation);
        }

        public void Exercise8()
        {
            int a = 7;
            int b = 9;
            int h = 3;
            var first = (a + b) * h;
            var equation = first / 2;
            Console.WriteLine("Pole trapezu to: ");
            Console.WriteLine(equation);
        }

        public void Exercise9()
        {
            int a = 3;
            int b = 5;
            int c = 4;
            int waga1 = 1;
            int waga2 = 2;
            int waga3 = 5;
            var first = a * waga1 + b * waga2 + c * waga3;
            var second = waga1 + waga2 + waga3;
            var equation = first / second;
            Console.WriteLine("Srednia wazona twoich ocen to: ");
            Console.WriteLine(equation);
        }

        public void Exercise1_IF()
        {
            Console.WriteLine("Podaj liczbę do sprawdzenia: ");
            string check_number = Console.ReadLine();
            int number = int.Parse(check_number);
            int devided_number = number % 2;
            if (devided_number == 0)
            {
                Console.WriteLine("Liczba jest parzysta ");
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta ");
            }
        }

        public void Exercise2_IF()
        {
            Console.WriteLine("Podaj liczbę do sprawdzenia:");
            string check_number = Console.ReadLine();
            int number = int.Parse(check_number);
            if (number == 0)
            {
                Console.WriteLine("Liczba jest rowna 0. ");
            }
            else if (number > 0)
            {
                Console.WriteLine("Liczba jest dodatnia. ");
            }
            else
            {
                Console.WriteLine("Liczba jest ujemna. ");
            }
        }

        public void Exercise3_IF()
        {
            Console.WriteLine("Podaj rok do sprawdzenia:");
            string check_year = Console.ReadLine();
            int year = int.Parse(check_year);
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Rok jest przestepny. ");
            }
            else
            {
                Console.WriteLine("Rok jest nieprzestepny. ");
            }
        }

        public void Exercise4_IF()
        {
            Console.WriteLine("Podaj ocene: ");
            string check_mark = Console.ReadLine();
            int mark = int.Parse(check_mark);
            if (mark > 6 && mark < 1)
            {
                Console.WriteLine("Podaj poprawna ocene. ");
            }
            if (mark == 6)
            {
                Console.WriteLine("Ocena celujaca. ");
            }
            if (mark == 5)
            {
                Console.WriteLine("Ocena bardzo dobra. ");
            }
            if (mark == 4)
            {
                Console.WriteLine("Ocena dobra. ");
            }
            if (mark == 3)
            {
                Console.WriteLine("Ocena poprawna. ");
            }
            if (mark == 2)
            {
                Console.WriteLine("Ocena dopuszczająca. ");
            }
            if (mark == 1)
            {
                Console.WriteLine("Ocena niedostateczna. ");
            }
        }

        public void Exercise5_IF()
        {
            Console.WriteLine("Podaj hasło: ");
            string password = Console.ReadLine();

            if (password == "abc123")
            {
                Console.Write("Haslo jest prawidlowe");
            }
            else
            {
                Console.Write("Haslo jest nieprawidlowe");
            }
        }
        public void Exercise6_IF()
        {
            Console.WriteLine("Podaj dzien: ");
            string check_day = Console.ReadLine();
            int day = int.Parse(check_day);

            Console.WriteLine("Podaj miesiac: ");
            string check_month = Console.ReadLine();
            int month = int.Parse(check_month);

            Console.WriteLine("Podaj rok: ");
            string check_year = Console.ReadLine();
            int year = int.Parse(check_year);

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Data jest poprawna.");
            }
            else
            {
                Console.WriteLine("Data jest niepoprawna.");
            }
            if (month > 12)
            {
                Console.WriteLine("Data jest niepoprawna.");
            }

            else if (month == 2 && day == 28)
            {
                Console.WriteLine("Miesiac jest poprawny.");
            }

            else if (month == 2 && day == 29)
            {
                Console.WriteLine("Miesiac jest poprawny.");
            }

            if (month == 4 && day <= 30)
            {
                Console.WriteLine("Data jest poprawna.");
            }

            if (month == 6 && day <= 30)
            {
                Console.WriteLine("Data jest poprawna.");
            }

            if (month == 9 && day <= 30)
            {
                Console.WriteLine("Data jest poprawna.");
            }

            if (month == 11 && day <= 30)
            {
                Console.WriteLine("Data jest poprawna.");
            }
        }
        public void Exercise7_IF()
        {
            Console.WriteLine("Podaj aktualna temperature:");
            string check_temperature = Console.ReadLine();
            int temperature = int.Parse(check_temperature);
            if (temperature >= 20)
            {
                Console.WriteLine("Jest cieplo");
            }
            else if (temperature >= 11 && temperature <= 19)
            {
                Console.WriteLine("Jest nawet spoko, mozna wyjsc");
            }
            else if (temperature <= 10)
            {
                Console.WriteLine("Jest chlodno, uwaga");
            }
            else if (temperature <= 0)
            {
                Console.WriteLine("Mrozi nie wychodz");
            }
        }

        public void Exercise1_FOR()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i + ", ");
            }
        }

        public void Exercise2_FOR()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.Write(i + 101 + ", ");
            }
        }

        public void Exercise3_FOR()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine((i * i) + "\n");
            }
        }
        public void Exercise4_FOR()
        {
            Console.WriteLine("Podaj liczbe: ");
            string check_silnia = Console.ReadLine();
            int silnia = int.Parse(check_silnia);

            for (int i = silnia; i > 1; i--)
            {
                silnia *= i;
            }

            Console.WriteLine(silnia);
        }

        public void Exercise5_FOR()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + (i * j));
                }
            }
        }
        public void Exercise6_FOR()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Exercise7_FOR()
        {
            int equation = 1;
            for (int i = 1; i <= 10; i++)
            {
                equation *= 2;
            }
            Console.WriteLine(equation);
        }

        public void Exercise8_FOR()
        {
            int firstnumber = -1;
            int secondnumber = 1;

            for (int i = 0; i < 20; i++)
            {
                int equation = firstnumber + secondnumber;

                firstnumber = secondnumber;
                secondnumber = equation;

                Console.WriteLine(secondnumber);
            }
        }

        public void Exercise9_FOR()
        {
            for (int i = 0; i <= 10; i++)
            {
                int equation = 1;
                for (int j = 0; j < i; j++)
                {
                    equation *= 2;
                }
                Console.WriteLine(equation);
            }
            // Albo krótszy i szybszy program, który domnaża kolejne liczby: 
            double a = 0.5;
            for (int i = 0; i <= 10; i++)
            {
                a *= 2;
                Console.WriteLine("2^" + i + "=" + a);

                //Console.WriteLine(a);
                //a *= 2;
            }
        }
        public void Exercise1_DO_WHILE()
        {
            Console.WriteLine("Podaj hasło: ");
            string password = Console.ReadLine();
            do
            {
                Console.WriteLine("Hasło prawidlowe");

            } while (password == "abc123");

            do
            {
                Console.WriteLine("Hasło nieprawidlowe");

            } while (password != "abc123");
        }
        public void Exercise2_DO_WHILE()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine((i * i) + "\n");
            }

            do
            {
                Console.WriteLine(i * i + i + i);
            } while ((i + i) <= 1000);

        }
    }
}

/*
 Podstawy programowania:
1. Program obliczający średnią arytmetyczną dwóch liczb.
2. Program obliczający pole prostokąta.
3. Program obliczający objętość stożka.
4. Program obliczający pole koła.
5. Program obliczający wartość wyrażenia a^2 + b^2
6. Program obliczający pole trójkąta o podstawie b i wysokości h
7. Program obliczający objętość kuli o promieniu r
8. Program obliczający pole trapezu o podstawach a i b oraz wysokości h
9. Program obliczający średnią ważoną trzech liczb z podanymi odpowiednimi wagami w1, w2 i w3.
Instrukcja If:
1. Program sprawdzający czy podana liczba jest parzysta czy nieparzysta
2. Program sprawdzający czy podana liczba jest dodatnia, ujemna czy równa zero
3. Program sprawdzający czy podany rok jest rokiem przestępnym
4. Program wyświetlający odpowiedni komunikat w zależności od podanej oceny (np. "bardzo dobry" dla oceny 5, "dobry" dla oceny 4 itd.)
5. Program sprawdzający czy podane hasło jest poprawne (np. jeśli hasło jest "abc123", program powinien wyświetlić "hasło poprawne", jeśli jest inne, powinien wyświetlić "hasło niepoprawne").
6.Program sprawdzający czy podana data jest poprawna (np. sprawdzając, czy dzień jest z zakresu od 1 do 31, miesiąc od 1 do 12 itd.)
7. Program wyświetlający odpowiedni komunikat w zależności od podanej temperatury (np. "ciepło" dla temperatury powyżej 20 stopni Celsjusza, "chłodno" dla temperatury poniżej 10 stopni Celsjusza itd.)
Pętle:
1. Program sprawdzający czy podana liczba jest liczbą pierwszą (czyli taką, która dzieli się tylko przez 1 i przez siebie samą)
2. Program sprawdzający czy podany ciąg znaków jest palindromem (czyli takim, który czytany od tyłu jest taki sam, jak czytany od przodu, np. "kajak")
3. Program sprawdzający czy podane dwa słowa są anagramami (czyli takimi, które zawierają te same litery, ale w innym układzie, np. "klasa" i "salka")
4. Program sprawdzający czy podana liczba jest liczbą doskonałą (czyli taką, której suma dzielników (z wyłączeniem samej siebie) jest równa danej liczbie, np. 6 jest liczbą doskonałą, ponieważ 1 + 2 + 3 = 6).
Pętla for:
1. Program wyświetlający na ekranie kolejne liczby naturalne od 1 do 10
2. Program obliczający sumę liczb od 1 do 100
3. Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.)
4. Program wyświetlający na ekranie silnie z liczb od 1 do 10 (np. 1!, 2!, 3!, 4! itd.)
5. Program wyświetlający na ekranie tabliczkę mnożenia od 1 do 9 (np. 1x1=1, 1x2=2, 1x3=3 itd.).
6. Program wyświetlający na ekranie wszystkie liczby podzielne przez 3 z zakresu od 1 do 100
7. Program obliczający sumę kwadratów liczb od 1 do 10
8. Program wyświetlający na ekranie ciąg Fibonacciego do 20 elementu (ciąg Fibonacciego to ciąg gdzie każdy element jest sumą dwóch poprzednich, np. 0, 1, 1, 2, 3, 5, 8, 13 itd.)
9. Program wyświetlający na ekranie kolejne potęgi 2 od 2^0 do 2^10 (np. 2^0, 2^1, 2^2 itd.)
10. Program wyświetlający na ekranie kolejne elementy ciągu a_n = a_{n-1} + a_{n-2}, gdzie a_0=1, a_1=1 (ciąg ten zaczyna się od 1, 1, 2, 3, 5, 8, 13 itd.).
Pętla do-while:
1. Program pytający użytkownika o hasło i wyświetlający komunikat "hasło poprawne" lub "hasło niepoprawne" dopóki użytkownik nie poda poprawnego hasła (np. "abc123").
2. Program wyświetlający na ekranie kwadraty liczb od 1 do 10 (np. 1, 4, 9, 16 itd.) dopóki suma tych kwadratów nie przekroczy 1000.
Trudniejsze zadania:
1. Program implementujący algorytm szyfrowania Cezara (proste szyfrowanie, w którym każdy znak w tekście jest zastępowany innym znakiem, przesuniętym o stałą liczbę pozycji w alfabecie).
2. Program obliczający największy wspólny dzielnik (NWD) dwóch liczb
3. Program obliczający najmniejszą wspólną wielokrotność (NWW) dwóch liczb.
4. Program wyciągający informacje z numeru PESEL
5. Napisz program, który pobiera od użytkownika ciąg znaków i wyświetla liczbę samogłosek i spółgłosek w tym ciągu.
*/