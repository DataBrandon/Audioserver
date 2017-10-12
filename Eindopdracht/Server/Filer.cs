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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;

    namespace Client
    {
        class Filer
        {

            public static void SavePlaylistOnDisk(List<string> toOutput)
            {
                SaveFileDialog saver = new SaveFileDialog();
                saver.DefaultExt = "plist";

                if (saver.ShowDialog() == DialogResult.OK)
                {
                    string filename = saver.FileName;

                    try
                    {
                        File.WriteAllLines(filename, toOutput.ToArray());
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("Cwash");
                    }
                }
            }


            public static List<string> LoadPlayListFromDisk(string file)
            {
                string filename = file;

                try
                {
                    List<string> importPlaylist = new List<string>();
                    string[] playList = File.ReadAllLines(filename);
                    foreach (string song in playList)
                    {
                        importPlaylist.Add(song);
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

            public static List<string> LoadPlayListFromDisk()
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
                            importPlaylist.Add(song);
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
    }

}
