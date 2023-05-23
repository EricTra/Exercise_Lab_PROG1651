using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class OnlineRadioDatabase
    {
        private List<Song> songs;

        public OnlineRadioDatabase()
        {
            songs = new List<Song>();
        }

        public void AddSong(string input)
        {
            string[] songData = input.Split(';');
            if (songData.Length != 3)
            {
                throw new InvalidSongException("Invalid song.");
            }

            string artist = songData[0];
            string name = songData[1];
            string length = songData[2];

            if (artist.Length < 3 || artist.Length > 20)
            {
                throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols.");
            }

            if (name.Length < 3 || name.Length > 30)
            {
                throw new InvalidSongNameException("Song name should be between 3 and 30 symbols.");
            }

            string[] lengthData = length.Split(':');
            if (lengthData.Length != 2)
            {
                throw new InvalidSongLengthException("Invalid song length.");
            }

            int minutes;
            int seconds;
            if (!int.TryParse(lengthData[0], out minutes) || minutes < 0 || minutes > 14)
            {
                throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
            }

            if (!int.TryParse(lengthData[1], out seconds) || seconds < 0 || seconds > 59)
            {
                throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
            }

            Song song = new Song(artist, name, minutes, seconds);
            songs.Add(song);
            Console.WriteLine("Song added.");
        }

        public void PrintPlaylistSummary()
        {
            Console.WriteLine($"Songs added: {songs.Count}");
            int totalSeconds = songs.Sum(s => s.Minutes * 60 + s.Seconds);
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;
            Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        }
    }
}
