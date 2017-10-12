using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;

namespace Server
{
    public partial class MediaPlayerForm : Form
    {
        private AxWindowsMediaPlayer player;

        public MediaPlayerForm()
        {
            InitializeComponent();
            player = WMP;
        }

        public void Play()
        {
            try
            {
                player?.Ctlcontrols.play();
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            
        }

        public void Pause()
        {
            player?.Ctlcontrols.pause();
        }

        public void Stop()
        {
            player?.Ctlcontrols.stop();
        }

        public void Next()
        {
            MusicLibrary.GetNextSongFromPlaylist(out string song);
            if (song != "")
            {
                PlaySelectedsong(song);
                Play();
            }
        }

        public void Previous()
        {
            MusicLibrary.GetPreviousSongFromPlaylist(out string song);
            if (song != "")
            {
                PlaySelectedsong(song);
                Play();
            }
        }

        public void PlaySelectedsong(string song)
        {
            if (player != null)
            {
                player.URL = Path.Combine(MusicLibrary.LibraryFolder, song);
                System.Diagnostics.Debug.WriteLine("Playing new song!!!");
                new Thread(() => {
                    Thread.Sleep(100);
                    Play();
                }).Start();
            }
        }

        public bool IsPlaying()
        {
            return player.playState == WMPPlayState.wmppsPlaying;
        }

        private void WMP_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                MusicLibrary.GetNextSongFromPlaylist(out string song);
                if (song != "")
                {
                    PlaySelectedsong(song);
                    Play();
                }
            }
        }

        private void selectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LibraryDialog.ShowDialog() == DialogResult.OK)
            {
                MusicLibrary.SetMusicLibraryFolder(LibraryDialog.SelectedPath);
                Play();
            }
            
        }

        private void loadPlayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusicLibrary.LoadPlayListFromDisk();
            MusicLibrary.GetNextSongFromPlaylist(out string song);
            PlaySelectedsong(song);
        }
    }
}
