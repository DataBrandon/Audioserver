using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientGui : Form
    {
        string ip = "127.0.0.1";
        int port = 6969;
        TcpClient _client;
        Session _session;
        Thread _readThread;

        public ClientGui()
        {
            InitializeComponent();
        }

        private void verbindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (IPAddress.TryParse(ip, out IPAddress _))
                {
                    _client = new TcpClient(ip, port);
                    _session = new Session(_client);
                    _readThread = new Thread(_session.Read);
                    _readThread.Start();
                    System.Diagnostics.Debug.WriteLine("Verbonden");
                }
                else
                {
                    throw new Exception("IPaddres invalid");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void verbreekVerbindingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _client?.Close();
            _readThread?.Abort();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                dynamic request = new
                {
                    Action = "song/play"
                };
                _session.Send(JsonConvert.SerializeObject(request));
            } else
            {
                MessageBox.Show("Not connected to server");
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                dynamic request = new
                {
                    Action = "song/pause"
                };
                _session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                MessageBox.Show("Not connected to server");
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                dynamic request = new
                {
                    Action = "song/stop"
                };
                _session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                MessageBox.Show("Not connected to server");
            }
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                dynamic request = new
                {
                    Action = "song/next"
                };
                _session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                MessageBox.Show("Not connected to server");
            }
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                dynamic request = new
                {
                    Action = "song/previous"
                };
                _session.Send(JsonConvert.SerializeObject(request));
            } else
            {
                MessageBox.Show("Not connected to server");
            }
        }

        private void refreshSongListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                dynamic request = new
                {
                    Action = "playlist/allsongs"
                };
                _session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                MessageBox.Show("Not connected to server");
            }
        }
    }
}
