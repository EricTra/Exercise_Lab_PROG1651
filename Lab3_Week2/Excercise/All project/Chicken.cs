using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_project
{
    internal class Chicken
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) throw new ArgumentException("Name cannot be empty.");
                else name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 15) throw new ArgumentException("Age should be between 0 and 15.");
                else age = value;
            }
        }

        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private int CalculateProductPerDay()
        {
            return 1;
        }

        public void ProductPerDay()
        {
            Console.WriteLine($"Chicken {Name} (age {Age}) can produce {CalculateProductPerDay()} eggs per day.");
        }
    }
}
