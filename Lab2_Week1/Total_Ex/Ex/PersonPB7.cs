using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex { 
    internal class PersonPB7
    {
        private string name;
        private string age;

        public string Name { get { return name; } set { name = value; } }
        public string Age { get { return age; } set { age = value; } }

        public PersonPB7(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public bool compareOlder(PersonPB7 other)
        {
            string otherAge = other.Age;
            string[] thisAge = age.Split('/');
            string[] anotherAge = otherAge.Split('/');

            for (int i = 2; i >= 0; i--)
            {
                if (int.Parse(thisAge[i]) < int.Parse(anotherAge[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
