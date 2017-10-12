using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientGui : Form
    {
        private readonly string _ip = "127.0.0.1";
        private readonly int _port = 6969;
        private TcpClient _client;
        private Session _session;
        private Thread _readThread;
        private List<string> editList;

        public ClientGui()
        {
            InitializeComponent();
            editList = new List<string>();
        }

        //Connect
        #region
        private void verbindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_session == null)
            {
                try
                {
                    if (IPAddress.TryParse(_ip, out IPAddress _))
                    {
                        _client = new TcpClient(_ip, _port);
                        _session = new Session(_client, this);
                        _readThread = new Thread(_session.Read);
                        _readThread.Start();
                        System.Diagnostics.Debug.WriteLine("Verbonden");
                        ServerStatus.Text = "Connected";
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
            else
            {
                MessageBox.Show("You are already connected to a server");
            }
        }
        #endregion

        //Disconnect
        #region
        private void verbreekVerbindingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dynamic request = new
            {
                Action = "disconnect"
            };
            _session?.Send(JsonConvert.SerializeObject(request));
            _client?.Close();
            _readThread?.Abort();
            _session = null;
            ServerStatus.Text = "Disconnected";
        }
        #endregion

        //Play
        #region
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                dynamic request = new
                {
                    Action = "song/play"
                };
                _session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                MessageBox.Show("Not connected to server");
            }
        }
        #endregion

        //Pause
        #region
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
        #endregion

        //Stop
        #region
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
        #endregion

        //Next
        #region
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
        #endregion

        //Previous
        #region
        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                dynamic request = new
                {
                    Action = "song/previous"
                };
                _session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                MessageBox.Show("Not connected to server");
            }
        }
        #endregion

        //Refresh song list
        #region
        private void refreshSongListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                dynamic request = new
                {
                    Action = "allsongs"
                };
                _session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                MessageBox.Show("Not connected to server");
            }
        }
        #endregion

        //Refresh song list
        #region
        private void GetCurrentPlaylist(object sender, EventArgs e)
        {
            if (_session != null)
            {
                dynamic request = new
                {
                    Action = "playlist/current/all"
                };
                _session.Send(JsonConvert.SerializeObject(request));
            }
            else
            {
                MessageBox.Show("Not connected to server");
            }
        }
        #endregion

        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentPlayListView.Enabled = true;
            CurrentPlayListView.Items.Clear();
        }

        private void importerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo songs naar playlist listview
            editList = Filer.ImportPlaylist();
            UpdateCurrentPlaylist(editList);
            CurrentPlayListView.Enabled = true;
        }

        private void exporterenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentPlayListView.Enabled == true)
            {
                Filer.ExportPlaylist(editList);
            }
        }

        //Disconnect on form closing
        #region
        private void ClientGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_session != null)
            {
                dynamic request = new
                {
                    Action = "disconnect"
                };
                _session.Send(JsonConvert.SerializeObject(request));
            }
        }
        #endregion

        public void UpdateAllSongs(List<string> songs)
        {
            AllSongList.BeginInvoke(new MethodInvoker(() =>
            {
                AllSongList.Items.Clear();
                foreach (string song in songs)
                {
                    AllSongList.Items.Add(song);
                }
            }));
        }

        public void UpdateCurrentPlaylist(List<string> songs)
        {
            CurrentPlayListView.BeginInvoke(new MethodInvoker(() =>
            {
                CurrentPlayListView.Items.Clear();
                foreach (string song in songs)
                {
                    CurrentPlayListView.Items.Add(song);
                }
            }));
        }

        private void AllSongList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedSong = AllSongList.SelectedItems[0].Text;
            dynamic toSend = new
            {
                Action = "play/selectedsong",
                data = new
                {
                    song = selectedSong
                }
            };
            _session.Send(JsonConvert.SerializeObject(toSend));
            editList.Add(selectedSong);
            UpdateCurrentPlaylist(editList);
        }

        private void CurrentPlayListView_DoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string selectedSong = CurrentPlayListView.SelectedItems[0].Text;

                editList.Remove(selectedSong);
                UpdateCurrentPlaylist(editList);
            }
            else
            {
                string selectedSong = CurrentPlayListView.SelectedItems[0].Text;
                dynamic toSend = new
                {
                    Action = "play/selectedsong",
                    data = new
                    {
                        song = selectedSong
                    }
                };
                _session.Send(JsonConvert.SerializeObject(toSend));

            }

        }

        private void addASongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "MP3 bestanden(*.mp3)|*.mp3";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string[] splittedPath = filePath.Split('\\');
                    string songname = splittedPath[splittedPath.Length - 1];
                    dynamic toSend = new
                    {
                        Action = "song/upload",
                        data = new
                        {
                            Action = "start",
                            songname = songname
                        }
                    };
                    _session.FileToTransfer = filePath;
                    _session.Send(JsonConvert.SerializeObject(toSend));
                }
            }
            else
            {
                MessageBox.Show("First you need to connect to the server");
            }
        }
    }
}
