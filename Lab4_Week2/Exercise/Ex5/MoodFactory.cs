using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class MoodFactory
    {
        public Mood CreateMood(int happinessPoints)
        {
            if (happinessPoints < -5)
                return new AngryMood();
            else if (happinessPoints >= -5 && happinessPoints <= 0)
                return new SadMood();
            else if (happinessPoints >= 1 && happinessPoints <= 15)
                return new HappyMood();
            else
                return new JavaScriptMood();
        }
    }

}
