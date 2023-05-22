using System;
using System.Collections.Generic;

namespace Ex6
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                    break;

                try
                {
                    string[] animalInfo = Console.ReadLine().Split();

                    string name = animalInfo[0];
                    int age = int.Parse(animalInfo[1]);
                    string gender = animalInfo[2];

                    Animal animal = null;

                    switch (animalType)
                    {
                        case "Dog":
                            animal = new Dog(name, age, gender);
                            break;
                        case "Frog":
                            animal = new Frog(name, age, gender);
                            break;
                        case "Cat":
                            if (gender == "Male")
                                animal = new Tomcat(name, age);
                            else if (gender == "Female")
                                animal = new Kitten(name, age);
                            else
                                throw new ArgumentException("Invalid input!");
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }

                    animals.Add(animal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
