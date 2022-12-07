using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestListOfObject
    {
        public void Test()
        {
            List<Person> listOfPeople = new List<Person>();

            Person person = new Person("Jan", "Kowalski", 40);
            listOfPeople.Add(person);

            listOfPeople.Add(new Person("Ewa", "Nowak", 36));
            listOfPeople.Add(new Person("Paweł", "Nieznany", 15));
            listOfPeople.Add(new Person("Bez", "Imienny", 14));

            Console.WriteLine("Lista wszystkich osób");
            foreach (Person p in listOfPeople)
            {
                p.Info();
            }

            List<Person> listofPeoplePegi18;

            listofPeoplePegi18 = listOfPeople.Where(x => x.age >= 18).ToList();

            Console.WriteLine("Lista osób pełnoletnich");
            foreach (Person p in listofPeoplePegi18)
            {
                p.Info();
            }

        }


    }
}
