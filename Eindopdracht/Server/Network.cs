using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Server
{
    public class Network
    {
        List<NetworkClient> myclients;
        

        public Network()
        {
            myclients = new List<NetworkClient>();

        }


        public void AddToList(TcpClient client)
        {
            myclients.Add(new NetworkClient(client));
        }







    }
}
