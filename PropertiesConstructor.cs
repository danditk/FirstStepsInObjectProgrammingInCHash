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
    }
    
}
