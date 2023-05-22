using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
        abstract class Food
        {
            public abstract int HappinessPoints { get; }
        }

        class Cram : Food
        {
            public override int HappinessPoints => 2;
        }

        class Lembas : Food
        {
            public override int HappinessPoints => 3;
        }

        class Apple : Food
        {
            public override int HappinessPoints => 1;
        }

        class Melon : Food
        {
            public override int HappinessPoints => 1;
        }

        class HoneyCake : Food
        {
            public override int HappinessPoints => 5;
        }

        class Mushroom : Food
        {
            public override int HappinessPoints => -10;
        }

        class OtherFood : Food
        {
            public override int HappinessPoints => -1;
        }

        abstract class Mood
        {
            public abstract string Name { get; }
        }

        class AngryMood : Mood
        {
            public override string Name => "Angry";
        }

        class SadMood : Mood
        {
            public override string Name => "Sad";
        }

        class HappyMood : Mood
        {
            public override string Name => "Happy";
        }

        class JavaScriptMood : Mood
        {
            public override string Name => "JavaScript";
        }

    }
