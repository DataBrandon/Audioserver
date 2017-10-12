using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class FileTransfer
    {

        private static string myip = "127.0.0.1";
        private readonly TcpListener listener;
        private readonly NetworkClient ntc;
        private TcpClient client;
        private NetworkStream stream;
        private string songname;

        public FileTransfer(string songname, NetworkClient ntc)
        {
            this.ntc = ntc;
            this.songname = songname;
            if (IPAddress.TryParse(myip, out IPAddress lookback))
            {
                listener = new TcpListener(lookback, 6970);
                listener.Start();
            }
        }

        public void ReceiveFile()
        {
            client = listener.AcceptTcpClient();
            stream = client.GetStream();
            byte[] prefixArray = new byte[4];
            stream.Read(prefixArray, 0, 4);
            int msgLength = BitConverter.ToInt32(prefixArray, 0);
            byte[] responseArray = new byte[msgLength];
            int bytesRead = 0;
            while (bytesRead < msgLength)
            {
                bytesRead += stream.Read(responseArray, bytesRead, responseArray.Length - bytesRead);
            }
            File.WriteAllBytes(Path.Combine(MusicLibrary.LibraryFolder, songname), responseArray);
            ntc.NotifyUploadDone();
            Close();
            MusicLibrary.IndexSongs();
            System.Diagnostics.Debug.WriteLine("Ontvangen: " + msgLength);
        }

        public void Close()
        {
            stream?.Close();
            client?.Close();
            listener?.Stop();
        }
    }
}
