using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    static class Program
    {
        private static MediaPlayerForm mediaPlayer;
        private static Network MyNetwork;
        private static string myip = "127.0.0.1";

        [STAThread]
        static void Main()
        {
            MusicLibrary.IndexSongs();
            new Thread(StartServer).Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mediaPlayer = new MediaPlayerForm();
            Application.Run(mediaPlayer);
        }

        public static void StartServer()
        {
            IPAddress lookback;
            if (IPAddress.TryParse(myip, out lookback))
            {
                MyNetwork = new Network();
                TcpListener listener = new TcpListener(lookback, 6969);
                listener.Start();
                System.Diagnostics.Debug.WriteLine("Waiting for Connection");
                while (true)
                {
                    try
                    {
                        TcpClient client = listener.AcceptTcpClient();
                        MyNetwork.AddToList(client);
                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Debug.WriteLine(e.Message);

                    }

                }
            }
            else { System.Diagnostics.Debug.WriteLine("CANT PARSE FOCK OFF"); }
        }

        public static void RecievedPlay()
        {
            mediaPlayer?.Play();
        }

        public static void RecievedPause()
        {
            mediaPlayer?.Pause();
        }

        public static void RecievedStop()
        {
            mediaPlayer?.Stop();
        }

        public static void PlaySelectedSong(string song)
        {
            MusicLibrary.AddSongToPlayListFront(song);
            if (!mediaPlayer.IsPlaying())
            {
                int songIndex = 0;
                MusicLibrary.currentIndex = songIndex;
                mediaPlayer?.PlaySelectedsong(song);
            }
        }

        public static void RecievedNext()
        {
            mediaPlayer?.Next();
        }

        public static void RecievedPrevious()
        {
            mediaPlayer?.Previous();
        }

        public static void CloseClient(NetworkClient networkClient)
        {
            MyNetwork?.RemoveFromList(networkClient);
        }
    }
}
