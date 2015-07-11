using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    public class PlayerScore : GameTimer
    {
        // Declared the integer that will store the score.
        public int score
        {
            get;
            set;
        }

        // Method for setting the score inside the object.
        public void setScore(int difficulty)
        {
            score = 5 * difficulty;
        }

        // Method for getting the score from inside the object.
        public int getScore()
        {
            return score;
        }

        // Method for adding to the score.
        public void addScore(int addedScore)
        {
            score = score + addedScore;
        }
    }
}
