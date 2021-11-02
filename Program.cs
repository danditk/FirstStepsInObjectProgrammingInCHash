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
            Person User1 = new Person("Phil");
            //User1.name = "Phil";
            User1.surname = "Konieczny";
            User1.gender = "Male";
            User1.age = 30;
            User1.hobby = "Cryptocurentsy";
            User1.job = "Rentier / YouTuber / Investor / FreeLancer";

            Person User2 = new Person("Maciek");
            //User2.name = "Maciek";
            User2.surname = "ZKlanu";
            User2.gender = "Męczyzna";
            User2.age = 38;
            User2.hobby = "Miłość";
            User2.job = "Aktor / Somelier / Wokalista / Multiinstrumentalista";

            Person User3 = new Person("Agatka");
            User3.surname = "Madej";
            User3.age = 19;
            User3.hobby = "Miłość";

            Person User4 = new Person();
            User4.surname = "Łukaszenko";
            User4.age = 74;
            User4.job = "Polityka";

            User1.Introduction();
            User2.Introduction();
            User3.Introduction();

            Console.ReadKey();
        }


    }
}
