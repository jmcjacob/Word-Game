using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    public class PlayerGame
    {
        // This is the deceleration of the integer that will store the player's choice of game.
        public int selectedGame
        {
            get;
            set;
        }

        // Method for setting the player game choice inside the object.
        public void setSelectedGame(int _selectedGame)
        {
            selectedGame = _selectedGame;
        }

        // Method for getting the players game choice from inside the object.
        public int getSelctedGame()
        {
            return selectedGame;
        }

        // Method for getting the game name based on the game choice inside the object.
        public string getGameName()
        {
            switch(selectedGame)
            {
                case 1:
                    return "Guess The Word";
                case 2:
                    return "Conundrum";
                case 3:
                    return "Fill in the Blanks";
                default:
                    return null;
            }
        }
    }
}
