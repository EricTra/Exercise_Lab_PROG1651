using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex6
{
    public abstract string ProduceSound();
    public override string ToString()
    {
        return $"{GetType().Name}{Environment.NewLine}{Name} {Age} {Gender}{Environment.NewLine}{ProduceSound()}";
    }


    class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }

    class Frog : Animal
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "Ribbit";
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "Meow meow";
        }
    }

    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, "Female")
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }

    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, "Male")
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
