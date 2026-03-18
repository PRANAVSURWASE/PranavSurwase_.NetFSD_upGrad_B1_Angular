namespace Music_Playlist_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Song> playlist = new LinkedList<Song>();

            playlist.AddFirst(new Song { Id = 1, Title = "Shape of you", Artist = "Ed sheeran" });

            playlist.AddLast(new Song { Id = 2, Title = "Believer", Artist = "Imagine Dragons" });
            playlist.AddLast(new Song { Id = 3, Title = "Blinding Lights", Artist = "The Weeknd" });

            var node = playlist.Find(playlist.First.Value);
            playlist.AddAfter(node, new Song { Id = 4, Title = "Perfect", Artist = "Ed Sheeran" });

            Console.WriteLine("Playlist (Forward Traversal)");
            foreach (var song in playlist)
            {
                Console.WriteLine(song);
            }

            Console.WriteLine("\nRemoving Song: Believer");
            var removeSong = playlist.First;
            while (removeSong != null)
            {
                if (removeSong.Value.Title == "Believer")
                {
                    playlist.Remove(removeSong);
                    break;
                }
                removeSong = removeSong.Next;
            }
            Console.WriteLine("\nPlaylist (Backward Traversal)");
            var current = playlist.Last;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Previous;
            }
            Console.WriteLine("\nSearching for song: Perfect");

            bool found = false;
            foreach (var song in playlist)
            {
                if (song.Title == "Perfect")
                {
                    Console.WriteLine("Song Found: " + song);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Song not found");
            }
            Console.WriteLine("\nPlay Next Feature");
            var play = playlist.First;

            if (play != null && play.Next != null)
            {
                Console.WriteLine("Current Song: " + play.Value);
                Console.WriteLine("Next Song: " + play.Next.Value);
            }







        }
    }
}
