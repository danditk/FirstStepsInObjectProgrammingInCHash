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
            //TODO
            name = constructorName;
            Console.WriteLine($"I AM {name}, and I AM CONSTRUCTOR");
            Console.WriteLine();
        }
        public Person(string constructorName, string constructorSurname)
        {
            name = constructorName;
            surname = constructorSurname;
        }

        public string name = "N";
        public string surname = "N";
        public string gender = "Nieokreślono";
        public int age = 999;
        public string hobby = "Brak";
        public string job = "Bezrobotny";

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
