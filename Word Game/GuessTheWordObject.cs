using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Word_Game
{
    // Public class inherits from the game class.
    public class GuessTheWordObject : Game
    {
        // Method for setting the new word.
        public void setNewWord()
        {
            newWord = "";
            foreach (char i in word)
            {
                newWord = newWord + "_ ";
            }
        }

        // Method to check if the character is present in the word.
        public bool checkChar(char i)
        {
            // Checks if the character is present.
            bool present = false;
            char[] letters = newWord.Replace(" ", string.Empty).ToCharArray();
            for (int j = 0; j < word.Length; j++)
            {
                if (i == word[j])
                {
                    present = true;
                    letters[j] = word[j];
                }
            }

            // If the character is present then add the character to the word.
            if (present)
            {
                newWord = Regex.Replace(new string(letters), ".{0}", "$0 ");
            }
            return present;
        }
    }
}
