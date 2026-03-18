using System;
using System.Collections.Generic;
using System.Text;

namespace Music_Playlist_System
{
    internal class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Title:{Title}, Artist:{Artist}";
        }
    }
}
