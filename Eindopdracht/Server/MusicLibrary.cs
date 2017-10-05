using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class MusicLibrary
    {
        public static string LibraryFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        public static List<string> songs = new List<string>();
        public static List<string> playList = new List<string>();
        private static int currentIndex = 0;

        public static void IndexSongs()
        {
            songs.Clear();
            foreach (string s in Directory.GetFiles(LibraryFolder))
            {
                if (s.Contains(".mp3"))
                {
                    string[] array = s.Split('\\');
                    string fileName = array[array.Length - 1];
                    songs.Add(fileName);
                }
            }
        }

        public static void SetMusicLibraryFolder(string folder)
        {
            LibraryFolder = folder;
            IndexSongs();
        }

        public static bool ContainsSong(string song)
        {
            return songs.Contains(song);
        }

        public static void AddSongToPlayListFront(string song)
        {
            playList.Add(song);
        }

        public static string GetNextSongFromPlaylist()
        {
            System.Diagnostics.Debug.WriteLine("Next: " + currentIndex);
            if (playList.Count > currentIndex)
            {
                string song = playList[currentIndex];
                currentIndex++;
                return song;
            }
            return "";
        }

        public static string GetPreviousSongFromPlaylist()
        {
            System.Diagnostics.Debug.WriteLine("Prev: " + currentIndex);
            if (playList.Any())
            {
                if (currentIndex > 0)
                {
                    currentIndex--;
                }
                return playList[currentIndex];
            }
            return "";
        }
    }
}
