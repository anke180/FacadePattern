using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;
        public CdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("CdPlayer on");
        }
        public void Off()
        {
            Console.WriteLine("CdPlayer off");
        }
        public void Eject()
        {
            Console.WriteLine("CdPlayer eject");
        }
        public void Pause()
        {
            Console.WriteLine("CdPlayer pause");
        }
        public void Play()
        {
            Console.WriteLine("CdPlayer play");
        }
        public void Stop()
        {
            Console.WriteLine("CdPlayer stop");
        }
    }
}
