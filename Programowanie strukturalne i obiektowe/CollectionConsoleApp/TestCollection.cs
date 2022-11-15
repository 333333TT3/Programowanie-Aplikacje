using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestCollection
    {
        public void TestArrayClollection()
        {
            int[] arrayOfNumber = new int[15];
            arrayOfNumber[5] = 2137;

            Random random = new Random();
            for (int i = 0; i < arrayOfNumber.Length; i++)
            {
                arrayOfNumber[i] = random.Next();
            }

            foreach (int item in arrayOfNumber)
            {
                Console.Write(item + ", ");
            }
            int max = arrayOfNumber[5];

            foreach (int number in arrayOfNumber)
            {
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max w tablicy to: " + max);
        }

        public void TestObjectArrayCollection()
        {
            Number[] arrayWidthObjectNumbers = new Number[5];

            Random random = new Random();
            for (int i = 0; i < arrayWidthObjectNumbers.Length; i++)
            {
                arrayWidthObjectNumbers[i] = new Number();
                arrayWidthObjectNumbers[i].ourNumber = random.Next() % 100;
            }

            foreach (Number number in arrayWidthObjectNumbers)
            {
                Console.Write($"{number.ourNumber}, ");
            }

            int max = arrayWidthObjectNumbers[0].ourNumber;
            foreach (Number number in arrayWidthObjectNumbers)
            {
                if (number.ourNumber > max)
                    max = number.ourNumber;
            }
            Console.WriteLine("\n Max w tablicy to: " + max);
        }
    }

    class Number
    {
        public int ourNumber;
    }
}