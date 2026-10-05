using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {

        private Amplifier amp;
        private CdPlayer cdPlayer;
        private DvdPlayer dvdPlayer;
        private PopcornPopper popcornPopper;
        private Projector projector;
        private Screen screen;
        private TheaterLights lights;
        private Tuner tuner;



        public HomeTheaterFacade(Amplifier amplifier, Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer, Projector projector, TheaterLights theaterLights, Screen screen, PopcornPopper popcornPopper)
        {
            this.amp = amplifier;
            this.tuner = tuner;
            this.dvdPlayer = dvdPlayer;
            this.cdPlayer = cdPlayer;
            this.projector = projector;
            this.lights = theaterLights;
            this.screen = screen;
            this.popcornPopper = popcornPopper;
        }

        public void WatchMovie(string movie)
        {
            popcornPopper.On();
            popcornPopper.Pop();

            lights.Dim(10);

            screen.Down();

            projector.On();
            projector.SetInput(dvdPlayer);
            projector.WideScreenMode();

            amp.On();
            amp.SetDvd(dvdPlayer);
            amp.SetSurroundSound();
            amp.SetVolume(5);

            dvdPlayer.On();
            dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            popcornPopper.Off();
            lights.On();
            screen.Up();
            projector.Off();
            amp.Off();
            dvdPlayer.Stop();
            dvdPlayer.Eject();
            dvdPlayer.Off();
        }
    }
}
