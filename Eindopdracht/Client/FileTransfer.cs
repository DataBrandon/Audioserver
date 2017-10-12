using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Client
{
    class FileTransfer
    {
        private string fileToTransfer;
        private TcpClient client;
        private NetworkStream stream;

        public FileTransfer(string ip, int port, string fileToTransfer)
        {
            this.fileToTransfer = fileToTransfer;
            client = new TcpClient(ip, port);
            stream = client.GetStream();
        }

        public void SendMP3()
        {
            byte[] file = File.ReadAllBytes(fileToTransfer);
            byte[] prefixArray = BitConverter.GetBytes(file.Length);
            byte[] buffer = new Byte[prefixArray.Length + file.Length];
            prefixArray.CopyTo(buffer, 0);
            file.CopyTo(buffer, prefixArray.Length);
            stream.Write(buffer, 0, buffer.Length);
            System.Diagnostics.Debug.WriteLine("Uploaden: " + file.Length);
        }

        public void Close()
        {
            stream?.Close();
            client?.Close();
        }
    }
}
