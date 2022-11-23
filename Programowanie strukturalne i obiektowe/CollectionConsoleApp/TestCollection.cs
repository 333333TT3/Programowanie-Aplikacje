﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestCollection
    {
        public void TestArrayCollection()
        {
            /*
            C++:
            typ nazwa[rozmiar];

            int tab1[5];

            tab1[2] = 2137;

            const int rozmiar = 19;
            //rozmiar = 17;
            int tab2[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {

            }
            */
            int[] arrayOfNumbers = new int[10];
            arrayOfNumbers[5] = 2137;

            Random random = new Random();
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next() % 100;
            }

            /*
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[i] + ", ");
            }
            */

            Console.WriteLine("Liczby w tablicy:");
            foreach (int item in arrayOfNumbers)
            {
                Console.Write(item + ", ");
                //item = 5;
            }
            Console.WriteLine();

            int max = arrayOfNumbers[0];
            foreach (int number in arrayOfNumbers)
            {
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max w tablicy to: " + max);
        }

        public void TestObjectArrayCollection()
        {
            Number[] arrayWidthObjectNumbers = new Number[5];
            //arrayWidthObjectNumbers[2].ourNumber = 7;

            Random random = new Random();
            for (int i = 0; i < arrayWidthObjectNumbers.Length; i++)
            {
                arrayWidthObjectNumbers[i] = new Number();
                arrayWidthObjectNumbers[i].ourNumber = random.Next() % 100;
            }

            foreach (Number number in arrayWidthObjectNumbers)
            {
                Console.Write($"{number.ourNumber} ,");
                //number = new Number();
                number.ourNumber = 7;
            }

            int max = arrayWidthObjectNumbers[0].ourNumber;
            foreach (Number number in arrayWidthObjectNumbers)
            {
                if (number.ourNumber > max)
                    max = number.ourNumber;
            }
            Console.WriteLine("Max w tablicy to: " + max);
        }

        public void TestGeneric()
        {
            Number[] numbers = new Number[5];
            NumberFloat[] floatnumbers = new NumberFloat[5];
            NumberDouble[] doublenumbers = new NumberDouble[5];

            NumberGeneric<int>[] intGenericNumber = new NumberGeneric<int>[5];
            NumberGeneric<float>[] floatGenericNumber = new NumberGeneric<float>[5];
            NumberGeneric<double>[] doubleGenericNumber = new NumberGeneric<double>[5];
            NumberGeneric<byte>[] byteGenericNumber = new NumberGeneric<byte>[5];
        }

    }

    class Number
    {
        public int ourNumber;
    }

    class NumberFloat
    {
        public float ourNumber;
    }

    class NumberDouble
    {
        public double ourNumber;
    }

    class NumberGeneric<T>
    {
        public T ourNumber;
    }
}