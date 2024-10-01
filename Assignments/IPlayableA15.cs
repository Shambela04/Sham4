using Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{

    internal interface IPlayable1
    {
        // Method Declaration 
        void PlayingAction(string play);
        void PauseAction(string Pause);

    }

    

    public class MusicPlayer : IPlayable1
    {
        public void PlayingAction(string play)
        {
            Console.WriteLine($" The Playing Music : {play} ");
        }

        public void PauseAction(string Pause)
        {
            Console.WriteLine($" The Playing Music : {Pause} ");
        }


    }


    public class VideoPlayer : IPlayable1
    {
        public void PlayingAction(string play)
        {
            Console.WriteLine($" The Playing video : {play} ");
        }

        public void PauseAction(string pause)
        {
            Console.WriteLine($" The Playing video : {pause} ");
            
        }
    }



    interface IPlayableA15
    {
        static void Main()
        {
            IPlayable1 music = new MusicPlayer();
            music.PlayingAction("Start");
            IPlayable1 music2 = new MusicPlayer();
            music.PauseAction("Stop");

            IPlayable1 video = new VideoPlayer();
            video.PlayingAction("Start1");
            IPlayable1 video1 = new VideoPlayer();
            video1.PlayingAction("Stop1");


        }
    }
}


    
   