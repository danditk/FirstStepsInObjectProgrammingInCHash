using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepsInObjectProgrammingInCHash
{
    class Person
    {
        public Person(string constructorName)
        {
            //TODO
            name = constructorName;
            Console.WriteLine($"I AM {name}, and I AM CONSTRUCTOR");
            Console.WriteLine();
        }

        public string name;
        public string surname;
        public string gender;
        public int age;
        public string hobby;
        public string job;

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
