using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepsInObjectProgrammingInCHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Person User1 = new Person();
            User1.name = "Phil";
            User1.surname = "Konieczny";
            User1.gender = "Male";
            User1.age = 30;
            User1.hobby = "Cryptocurentsy";
            User1.job = "Rentier / YouTuber / Investor / FreeLancer";

            Person User2 = new Person();
            User2.name = "Maciek";
            User2.surname = "ZKlanu";
            User2.gender = "Męczyzna";
            User2.age = 38;
            User2.hobby = "Miłość";
            User2.job = "Aktor / Somelier / Wokalista / Multiinstrumentalista";

            User1.Introduction();
            User2.Introduction();

            Console.ReadKey();
        }

        class Person
        {
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
        }

    }
}
