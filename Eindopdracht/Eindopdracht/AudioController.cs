using System;
using System.IO;
namespace Eindopdracht
{
    public class AudioController
    {
        System.Media.SoundPlayer myplayer;
        
        public AudioController()
        {
            String mypath = Path.Combine(Directory.GetCurrentDirectory(),"maya greet.wav");
            myplayer = new System.Media.SoundPlayer(mypath);

            myplayer.Play();
            Console.WriteLine("playing");
        }
    }
}
