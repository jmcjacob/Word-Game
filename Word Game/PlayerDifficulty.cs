using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    public class PlayerDifficulty
    {
        // This is the deceleration of the integer that will store the player's choice of difficulty.
        public int selectedDifficulty
        {
            get;
            set;
        }

        // Method for setting the player difficulty choice inside the object.
        public void setSelectedDifficulty(int _selectedDifficulty)
        {
            selectedDifficulty = _selectedDifficulty;
        }

        // Method for getting the players difficulty choice from inside the object.
        public int getSelectedDifficulty()
        {
            return selectedDifficulty;
        }

        // Method for returning the difficulty name.
        public string getDifficultyName()
        {
            switch(selectedDifficulty)
            {
                case 1:
                    return "Easy";
                case 2:
                    return "Medium";
                case 3:
                    return "Hard";
                default:
                    return null;
            }
        }
    }
}
