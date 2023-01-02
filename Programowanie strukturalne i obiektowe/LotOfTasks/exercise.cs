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
    }
}