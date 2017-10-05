using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {

            string myip = "127.0.0.1";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Network MyNetwork;
            IPAddress lookback;
            if (IPAddress.TryParse(myip, out lookback))
            {
                MyNetwork = new Network();
                TcpListener listener = new TcpListener(lookback, 6969);
                listener.Start();
                Console.WriteLine("Waiting for Connection");
                while (true)
                {
                    try
                    {
                        TcpClient client = listener.AcceptTcpClient();
                        MyNetwork.AddToList(client);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }

                }
            }
            else { Console.WriteLine("CANT PARSE FOCK OFF"); }

        }
    }
}
