using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace Client
{
    class Session
    {
        private readonly NetworkStream _stream;
        private readonly ClientGui gui;

        public Session(TcpClient client, ClientGui gui)
        {
            _stream = client.GetStream();
            this.gui = gui;
        }

        //Send to client
        #region
        public void Send(string message)
        {
            System.Diagnostics.Debug.WriteLine("Send: \r\n" + message);
            byte[] prefixArray = BitConverter.GetBytes(message.Length);
            byte[] requestArray = Encoding.Default.GetBytes(message);
            byte[] buffer = new Byte[prefixArray.Length + message.Length];
            prefixArray.CopyTo(buffer, 0);
            requestArray.CopyTo(buffer, prefixArray.Length);
            _stream.Write(buffer, 0, buffer.Length);
        }
        #endregion

        //Read from client
        #region
        public void Read()
        {
            while (true)
            {
                try
                {
                    StringBuilder response = new StringBuilder();
                    int totalBytesreceived = 0;
                    int lengthMessage = -1;
                    byte[] receiveBuffer = new byte[1024];
                    bool messagereceived = false;

                    do
                    {
                        int numberOfBytesRead = _stream.Read(receiveBuffer, 0, receiveBuffer.Length);
                        totalBytesreceived += numberOfBytesRead;
                        string received = Encoding.ASCII.GetString(receiveBuffer, 0, numberOfBytesRead);
                        response.AppendFormat("{0}", received);
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
                        }
                        else if ((totalBytesreceived - 4) == lengthMessage)
                        {
                            messagereceived = true;
                        }
                    }
                    while (!messagereceived);
                    _stream.Flush();
                    string toReturn = response.ToString().Substring(4);
                    System.Diagnostics.Debug.WriteLine("Received: \r\n" + toReturn);
                    ProcesAnswer(JsonConvert.DeserializeObject(toReturn));
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            }
        }
        #endregion

        public void ProcesAnswer(dynamic jsonData)
        {
            if (jsonData.Action == "allsongs")
            {
                List<string> songs = new List<string>();
                foreach (dynamic s in jsonData.data.songs)
                {
                    songs.Add((string)s);
                }
                gui.UpdateAllSongs(songs);
            }
            else if (jsonData.Action == "playlist/current/all")
            {
                List<string> songs = new List<string>();
                foreach (dynamic s in jsonData.data.songs)
                {
                    songs.Add((string)s);
                }
                //TO DO Nog wijzigen naar current playlist listview
                gui.UpdateAllSongs(songs);
            }
        }
    }
}
