using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Client;

namespace Server
{
    class MusicLibrary
    {
        public static string LibraryFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        public static List<string> songs = new List<string>();
        public static List<string> playList = new List<string>();
        public static int currentIndex { get; set; }

        public static void IndexSongs()
        {
            songs.Clear();
            foreach (string s in Directory.GetFiles(LibraryFolder))
            {
                if (s.Contains(".mp3") || s.Contains(".mp4"))
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
            List<string> newPlaylist = new List<string>();
            newPlaylist.Add(song);
            newPlaylist.AddRange(playList);
            playList = newPlaylist;
            currentIndex++;
        }

        public static void GetNextSongFromPlaylist(out string song)
        {
            if (playList.Count > currentIndex + 1)
            {
                currentIndex++;
                song = playList[currentIndex];
            }
            else
            {
                song = "";
            }
        }

        public static void GetPreviousSongFromPlaylist(out string song)
        {
            if (playList.Any())
            {
                if (currentIndex > 0)
                {
                    currentIndex--;
                }
                song = playList[currentIndex];
            }
            else
            {
                song = "";
            }
        }

        public static void PrintPlaylist()
        {
            foreach (string song in playList)
            {
                System.Diagnostics.Debug.Write(song);
            }
            System.Diagnostics.Debug.WriteLine("");
        }

        public static void ExportPlayListToDisk()
        {
            Filer.SavePlaylistOnDisk(playList);
        }

        public static void LoadPlayListFromDisk(string defaultPath)
        {
            playList = Filer.LoadPlayListFromDisk(defaultPath);
            
        }

        public static void LoadPlayListFromDisk()
        {
             playList = Filer.LoadPlayListFromDisk();
        }

        public static void LoadNewPlaylist(List<string> songs)
        {
            playList = songs;
            currentIndex = 0;
        }

        public static (string, List<string>) GetCurrentState()
        {
            string currentsong = "";
            if (MusicLibrary.playList.Count > MusicLibrary.currentIndex)
            {
                currentsong = MusicLibrary.playList[MusicLibrary.currentIndex];
            }
            return (currentsong, playList);
        }
    }
}
