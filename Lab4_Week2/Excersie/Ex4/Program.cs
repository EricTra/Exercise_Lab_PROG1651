using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            OnlineRadioDatabase radioDatabase = new OnlineRadioDatabase();

            for (int i = 0; i < numberOfSongs; i++)
            {
                try
                {
                    string songData = Console.ReadLine();
                    radioDatabase.AddSong(songData);
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            radioDatabase.PrintPlaylistSummary();
        }
    }
}

