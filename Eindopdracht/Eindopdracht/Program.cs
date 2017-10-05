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
        AudioController audiocontroller;




		static void Main(string[] args)
        {
            
            IPAddress lookback = new IPAddress.TryParse("127.0.0.1");
            TcpListener listener = new TcpListener(lookback, 6969);




            listener.Start();
            while(true){
                Console.WriteLine("Waiting for Connection");
                try
                {
                    TcpClient client = listener.AcceptTcpClient();

                    Thread t = new Thread();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);

                }

            }



        }
    }
}
