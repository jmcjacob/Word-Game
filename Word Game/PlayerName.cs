using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    public class PlayerName
    {
        // This is the deceleration of the string that will store the name.
        public string playerName
        {
            get;
            set;
        }

        // This is the method that will set the player name inside the object.
        public void setPlayerName(string _playerName)
        {
            playerName = _playerName;
        }

        // This is the method that will get the player name from inside the object.
        public string getPlayerName()
        {
            return playerName;
        }

        // Method to check if player name inside the object is valid.
        public bool checkValidName()
        {
            bool check = true;
            if (playerName.Length <= 1 || playerName.Length >= 50)
                check = false;
            else
            {
                foreach(char i in playerName)
                {
                    if (char.IsLetter(i) || i == ' ' || i == '.' || i == '-') { }
                    else check = false;
                }
            }
            return check;
        }
    }
}
