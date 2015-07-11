using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    public class GameTimer
    {
        // Variable for storing the time.
        public int timer
        {
            get;
            set;
        }

        // Method for setting the time based on selected difficulty.
        public void setTimer(int difficulty)
        {
            timer = 20 * difficulty;
        }

        // Method to return the time.
        public int getTime()
        {
            return timer;
        }

        // Method for ticking the timer.
        public void tickTimer()
        {
            timer--;
        }
    }
}
