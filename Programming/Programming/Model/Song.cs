﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        private int _songDuration;

        public int SongDuration
        {
            get { return _songDuration; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be a positive number");
                }
                _songDuration = value;
            }
        }
        public Song(string artist, string name, string genre, int songDuration)
        {
            Artist = artist;
            Name = name;
            Genre = genre;
            SongDuration = songDuration;
        }
        public Song()
        {
            Artist = "Linkin Park";
            Name = "Breaking the Habit";
            Genre = "Alternative Rock";
            SongDuration = 196;
        }
    }
}
