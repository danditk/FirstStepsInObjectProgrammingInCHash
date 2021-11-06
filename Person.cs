using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepsInObjectProgrammingInCHash
{
    class Person
    {
        public Person()
        {

        }
        
        public Person(string constructorName)
        {
            name = constructorName;
            //Console.WriteLine($"I AM {name}, and I AM CONSTRUCTOR");
            //Console.WriteLine();
        }
        public Person(string constructorName, string constructorSurname)
        {
            name = constructorName;
            surname = constructorSurname;
        }

        public Person(string constructorName, string constructorSurname, string consGender, string consHobby, int consAge)
        {
            name = constructorName;
            surname = constructorSurname;
            gender = consGender;
            hobby = consHobby;
            age = consAge;
        }

        public string name = "N";
        public string surname = "N";
        public string gender = "Nieokreślono";
        public string hobby = "Brak";
        public string job = "Bezrobotny";

        private int age;

        public int AgeProperty
        {
            get { return age; }

            set
            {
                if (value >= 0 && value <= 200)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }

            }
        }


        
        public void Introduction()
        {
            Console.WriteLine($"Mam na imie {name}, a na nazwisko {surname}.");
            Console.WriteLine($"Moja oficialna płeć to {gender} i mam {age} lat.");
            Console.WriteLine($"Mój zawód to {job},\na w wolnym czasie lubię spędzać czas nad: {hobby}, bo to moje hobby ;).");
            Console.WriteLine(); Console.WriteLine();
        }

        ~Person()
        {
            //TODO
            System.Diagnostics.Trace.WriteLine("I AM DENSTRUCTOR");
        }
    }
}
