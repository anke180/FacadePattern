using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DvdPlayer on");
        }
        public void Off()
        {
            Console.WriteLine("DvdPlayer off");
        }
        public void Eject()
        {
            Console.WriteLine("DvdPlayer eject");
        }
        public void Pause()
        {
            Console.WriteLine("DvdPlayer pause");
        }
        public void Play(string movie)
        {
            Console.WriteLine($"DvdPlayer playing {movie}");
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("DvdPlayer surround audio");
        }
        public void SetTWoChannelAudio()
        {
            Console.WriteLine("DvdPlayer two channel audio");
        }
        public void Stop()
        {
            Console.WriteLine("DvdPlayer stop");
        }
    }
}
