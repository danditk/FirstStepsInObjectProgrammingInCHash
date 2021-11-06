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
            PropertiesConstructor man = new PropertiesConstructor();
            man.setName("Patrycja");  // = "Patrycja";
            man.setAge(24); // = 43;
            
            Console.WriteLine("Jestem {0} i mam {1} lat", man.getName(), man.getAge());

            Person[] tabPersons = new Person[6];

            Person User1 = new Person("Phil");
            //User1.name = "Phil";
            User1.surname = "Konieczny";
            User1.gender = "Male";
            User1.AgeProperty = 30;
            User1.hobby = "Cryptocurentsy";
            User1.job = "Rentier / YouTuber / Investor / FreeLancer";

            Person User2 = new Person("Maciek");
            //User2.name = "Maciek";
            User2.surname = "ZKlanu";
            User2.gender = "Męczyzna";
            User2.AgeProperty = 38;
            User2.hobby = "Miłość";
            User2.job = "Aktor / Somelier / Wokalista / Multiinstrumentalista";

            Person User3 = new Person("Agatka");
            User3.surname = "Madej";
            User3.AgeProperty = 19;
            User3.hobby = "Miłość";

            Person User4 = new Person("");
            User4.surname = "Łukaszenko";
            User4.AgeProperty = 74;
            User4.job = "Polityka";

            Person User5 = new Person("TestAge1");
            User5.AgeProperty = -1;

            Person User6 = new Person("TestAge2");
            User6.AgeProperty = 250;


            tabPersons[0] = User1;
            tabPersons[1] = User2;
            tabPersons[2] = User3;
            tabPersons[3] = User4;
            tabPersons[4] = User5;
            tabPersons[5] = User6;
            //string users 

            foreach (var person in tabPersons)
            {
                person.Introduction();
            }

            //for (int i = 0; i < tabPersons.Length; i++)
            //{
            //    tabPersons[i].Introduction();
            //}
            //User1.Introduction();
            //User2.Introduction();
            //User3.Introduction();
            //User4.Introduction();
            //User5.Introduction();
            //User6.Introduction();

            Console.ReadKey();
        }


    }
}
