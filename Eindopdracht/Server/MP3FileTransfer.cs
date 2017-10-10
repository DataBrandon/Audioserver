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
    class MP3FileTransfer
    {

        private static string myip = "127.0.0.1";
        private readonly TcpListener listener;
        private readonly NetworkClient ntc;
        private TcpClient client;
        private NetworkStream stream;
        private string songname;

        public MP3FileTransfer(string songname, NetworkClient ntc)
        {
            this.ntc = ntc;
            this.songname = songname;
            IPAddress lookback;
            if (IPAddress.TryParse(myip, out lookback))
            {
                listener = new TcpListener(lookback, 6970);
                listener.Start();
            }
        }

        public void ReceiveMP3()
        {
            List<Byte> totalReceived = new List<byte>();
            try
            {
                client = listener.AcceptTcpClient();
                stream = client.GetStream();
                StringBuilder response = new StringBuilder();
                int totalBytesreceived = 0;
                int lengthMessage = -1;
                byte[] receiveBuffer = new byte[1024];
                bool messagereceived = false;

                do
                {
                    int numberOfBytesRead = stream.Read(receiveBuffer, 0, receiveBuffer.Length);
                    totalBytesreceived += numberOfBytesRead;
                    if (lengthMessage == -1)
                    {
                        if (receiveBuffer.Length >= 4)
                        {
                            Byte[] lengthMessageArray = new Byte[4];
                            Array.Copy(receiveBuffer, 0, lengthMessageArray, 0, 3);
                            lengthMessage = BitConverter.ToInt32(lengthMessageArray, 0);
                            if ((totalBytesreceived - 4) == lengthMessage)
                            {
                                messagereceived = true;
                            }
                        }
                        foreach (byte b in receiveBuffer)
                        {
                            totalReceived.Add(b);
                        }
                    } else if ((totalBytesreceived - 4) == lengthMessage)
                    {
                        messagereceived = true;
                        int x = 0;
                        while (totalReceived.Count -4 != (lengthMessage))
                        {
                            totalReceived.Add(receiveBuffer[x]);
                            x++;
                        }
                    }
                    else
                    {
                        foreach (byte b in receiveBuffer)
                        {
                            totalReceived.Add(b);
                        }
                    }
                } while (!messagereceived);
                stream.Flush();
                File.WriteAllBytes(Path.Combine(MusicLibrary.LibraryFolder, songname), totalReceived.ToArray());
                ntc.NotifyUploadDone();
                Close();
                MusicLibrary.IndexSongs();
            }
            catch (Exception e)
            {
                ntc.NotifyUploadError(e.Message);
                Close();
            }
        }

        public void Close()
        {
            stream?.Close();
            client?.Close();
            listener?.Stop();
        }
    }
}
