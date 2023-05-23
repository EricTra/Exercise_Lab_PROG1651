using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Song
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Song(string artist, string name, int minutes, int seconds)
        {
            Artist = artist;
            Name = name;
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
        {
            return $"{Name} by {Artist}";
        }
    }
}
