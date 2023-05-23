using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class InvalidSongException : Exception
    {
        public InvalidSongException(string message) : base(message)
        {
        }
    }

    class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException(string message) : base(message)
        {
        }
    }

    class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException(string message) : base(message)
        {
        }
    }

    class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException(string message) : base(message)
        {
        }
    }

    class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException(string message) : base(message)
        {
        }
    }

    class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException(string message) : base(message)
        {
        }
    }
}
