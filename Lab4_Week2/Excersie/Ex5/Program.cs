
using System;
using System.Collections.Generic;


namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = Console.ReadLine().Split(' ');

            FoodFactory foodFactory = new FoodFactory();
            MoodFactory moodFactory = new MoodFactory();

            int totalHappinessPoints = 0;

            foreach (string food in foods)
            {
                Food currentFood = foodFactory.CreateFood(food);
                totalHappinessPoints += currentFood.HappinessPoints;
            }

            Mood currentMood = moodFactory.CreateMood(totalHappinessPoints);

            Console.WriteLine(totalHappinessPoints);
            Console.WriteLine(currentMood.Name);
        }
    }
}
