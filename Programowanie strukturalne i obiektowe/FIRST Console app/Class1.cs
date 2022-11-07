using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_Console_app
{
    class Person
    {
        private string name;
        private string surname;
        private int age;

        public Person()
        {
            name = "Imie";
            surname = "Nazwisko";
            age = 21;
        }

            public Person(string name, string surname, int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;

            }
    }
}
