using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    class Filer
    {

        public static void ExportPlaylist(List<string> toOutput)
        {
            FolderBrowserDialog folderchooser = new FolderBrowserDialog();
            folderchooser.RootFolder = Environment.SpecialFolder.MyMusic;

            if (folderchooser.ShowDialog() == DialogResult.OK)
            {
                string foldername = folderchooser.SelectedPath;
                string filename = Prompt.ShowDialog("Kies de naam voor de playlist", "Filename");

                try
                {
                    File.WriteAllLines(foldername + filename + ".plist", toOutput.ToArray());
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Cwash");
                }
            }
        }


        public static List<string> ImportPlaylist()
        {

            OpenFileDialog openfile = new OpenFileDialog();
            
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string filename = openfile.FileName;

                try
                {
                    List<string> importPlaylist = new List<string>();
                    string[] playList = File.ReadAllLines(filename);
                    foreach (string song in playList)
                    {
                        if (MusicLibrary.ContainsSong(song))
                        {
                            importPlaylist.Add(song);
                        }
                    }

                    return importPlaylist;
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Cwash read");
                }

                return new List<string>();
            }

            return null;

        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
