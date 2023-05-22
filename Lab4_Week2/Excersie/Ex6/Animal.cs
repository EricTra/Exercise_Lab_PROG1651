using Ex6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex6
{
    abstract class Animal : ISoundProducable
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public string Gender { get; protected set; }

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{GetType().Name}{Environment.NewLine}{Name} {Age} {Gender}{Environment.NewLine}{ProduceSound()}";
        }
    }
   
}
