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

            List<double> listOfFDoubles = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                double number = random.NextDouble() * 10 + 1;
                number = Math.Round(number, 4);

                listOfFDoubles.Add(number);

            }
            Console.WriteLine("Lista doubl'ow:");
            foreach (double element in listOfFDoubles)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();

            int max = MaxFromInts(listOfInts);
            Console.WriteLine("Max w liscie int'ow: " + max);

            int maxDouble = MaxFromInts(listOfDoubles);
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
    }
}
