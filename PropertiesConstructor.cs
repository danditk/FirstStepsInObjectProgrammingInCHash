using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepsInObjectProgrammingInCHash
{
    class PropertiesConstructor
    {
        private string name;

        // in different languages for example Jawa we build properties like this:

        public string getName()
        {
            return name;
        }

        public void setName(string sName)
        {
            name = sName;
        }

        private int age = 0;

        public int getAge()
        {
            return age;
        }

        public void setAge(int sAge)
        {
            if (sAge < 0 && sAge > 200) age = sAge;
        }

        // in C# we can build properties using - Gettery i settery, internal solutions like this:

        // public string gender { get; set; } // () peop and click 2X tab - simple , you can use also only get

        private string gender;

        public string PersonGender
        {
            get { return "SEX:" + gender; }

            set
            {
                if (value == "male" || value == "female" || value == "kobieta" || value == "mężczyzna" || value == "nie chcę podawać")
                gender = value;

                else
                {
                    gender = "nieokreślono";
                }
            }
            
        }

        //public string gender { get; set; } // peopfull and click 2X tab - full property witch you can add some conditions

    }
    
}
