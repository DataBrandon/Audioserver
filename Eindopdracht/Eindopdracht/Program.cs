using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;



namespace Eindopdracht
{
    class Program
    {
        static AudioController audiocontroller;
        static string myip = "127.0.0.1";

		static void Main(string[] args)
        {
            audiocontroller = new AudioController();
            Network MyNetwork;
            IPAddress lookback;
            if(IPAddress.TryParse(myip,out lookback)) {
                MyNetwork = new Network();
				TcpListener listener = new TcpListener(lookback, 6969);
                listener.Start();
                Console.WriteLine("Waiting for Connection");
                while (true)
				{
					try
					{
						TcpClient client = listener.AcceptTcpClient();
					    Console.WriteLine("Connected to " + client.Client.AddressFamily.ToString());
                        MyNetwork.AddToList(client);
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);

					}

				}  
            }
            else{Console.WriteLine("CANT PARSE FOCK OFF"); }


        }
    }
}
