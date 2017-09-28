using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        string ip = "127.0.0.1";
        int port = 6969;
        TcpClient client;
        Session session;
        Thread readThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void verbindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress hostIP;
                if (IPAddress.TryParse(ip, out hostIP))
                {
                    client = new TcpClient(ip, port);
                    session = new Session(client);
                    readThread = new Thread(session.Read);
                    readThread.Start();
                    System.Diagnostics.Debug.WriteLine("Verbonden");
                }
                else
                {
                    throw new Exception("IPaddres invalid");
                }
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }
        }

        private void verbreekVerbindingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.Close();
            }
            if (readThread != null)
            {
                readThread.Abort();
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session != null)
            {
                dynamic request = new
                {
                    Action = "song/play"
                };
                session.Send(JsonConvert.SerializeObject(request));
            } else
            {
                System.Windows.Forms.MessageBox.Show("Not connected to server");
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session != null)
            {
                dynamic request = new
                {
                    Action = "song/pause"
                };
                session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not connected to server");
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session != null)
            {
                dynamic request = new
                {
                    Action = "song/stop"
                };
                session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not connected to server");
            }
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session != null)
            {
                dynamic request = new
                {
                    Action = "song/next"
                };
                session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not connected to server");
            }
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session != null)
            {
                dynamic request = new
                {
                    Action = "song/previous"
                };
                session.Send(JsonConvert.SerializeObject(request));
            } else
            {
                System.Windows.Forms.MessageBox.Show("Not connected to server");
            }
        }

        private void refreshSongListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (session != null)
            {
                dynamic request = new
                {
                    Action = "playlist/allsongs"
                };
                session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not connected to server");
            }
        }
    }
}
