using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestListCollection
    {
        public void FirstTest()
        {
            Random random = new Random();

            List<int> listOfInts = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                listOfInts.Add(random.Next(1, 11));
            }
            Console.WriteLine("Lista int'ow:");
            foreach (int element in listOfInts)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();

            List<double> listOfDoubles = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                double number = random.NextDouble() * 10 + 1;
                number = Math.Round(number, 4);

                listOfDoubles.Add(number);

            }
            Console.WriteLine("Lista doubl'ow:");
            foreach (double element in listOfDoubles)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();

            //int max = MaxFromInts(listOfInts);
            //int max = MaxFromAllTypes<int>(listOfInts, CheckInt);
            int max = MaxFromAllTypes<int>(listOfInts,
                (int firstNumber, int secondNumber) =>
                {
                    return firstNumber > secondNumber;
                });
            Console.WriteLine("Max w liscie int'ow: " + max);

            //double maxDouble = MaxFromDoubles(listOfFDoubles);
            double maxDouble = MaxFromAllTypes<double>(listOfDoubles, (double firstNumber, double secondNumber ) => firstNumber > secondNumber);
            Console.WriteLine("Max w liscie doubl'ow: " + maxDouble);

        }

        private int MaxFromInts(List<int> list)
        {
            int max = list[0];
            foreach (int item in list)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
        /*
        private T MaxFromAllTypes<T>(List<T> list, Func<T, T, bool> check)
        {
            T max = list[0];
            foreach (T item in list)
            {
                if (check(item, max))
                    max = item;
            }
            return max;
        } */
        private T MaxFromAllTypes<T>(List<T> list, Func<T, T, bool> check)
        {
            T max = list[0];
            foreach (T item in list)
            {
                /* if (item is int)
                 {
                     if (CheckInt(int.Parse(item.ToString()), int.Parse(max.ToString())))
                         max = item;
                 }
                 if (item is double)
                 {
                     if (CheckDouble(double.Parse(item.ToString()), double.Parse(max.ToString())))
                         max = item;
                 }
                 if(item is Person)
                   {
                   (CheckPerson(item as Person, max as Person)
                   max = item;
                   } 

                if (item > max)
                max = item;
                */

                if (check(item, max))
                    max = item;
            }
            return max;
        }
        private bool CheckInt(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber;
        }

        private bool CheckDouble(double firstNumber, double secondNumber)
        {
            return firstNumber > secondNumber;
        }
        /*
         private Person CheckPerson(Person firstPerson, Person secondPerson)
          {
          return firstPerson.age > secondPerson.age;
          }
         */
    }
}