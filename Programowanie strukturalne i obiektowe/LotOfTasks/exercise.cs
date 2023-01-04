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

            if (month == 4 && day <= 30 )
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
            if (temperature >= 20 )
            {
                Console.WriteLine("Jest cieplo");
            }
            else if(temperature >= 11 && temperature <= 19)
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

        public void Exercise1_petle()
        {
            Console.WriteLine("Podaj liczbę:");
            string check_first = Console.ReadLine();
            int first = int.Parse(check_first);

        }
    }
}