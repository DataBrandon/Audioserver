using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Eindopdracht
{
    public class AudioController
    {
        private MediaPlayerForm mediaPlayer;
        private Thread playerThread;
        
        public AudioController()
        {
            mediaPlayer = new MediaPlayerForm();
            playerThread = new Thread(mediaPlayer.Start);
            playerThread.Start();
        }

        public void Close()
        {
            playerThread.Abort();
        }
    }
}
