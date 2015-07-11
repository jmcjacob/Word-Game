using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    // Sets the class to public and inherits from the game class.
    public class ConundrumObject : Game
    {
        // Method to jumble up a word.
        public void jumbleWord()
        {
            // Declares the variables used in the method
            Random rnd = new Random();
            bool checkSame = true;

            // Loops to make sure that the word is a new word.
            while (checkSame)
            {
                // Jumbles up the word and sets it as new word.
                newWord = new string(word.ToCharArray().OrderBy(s => (rnd.Next(2) % 2) == 0).ToArray());
                // Checks if the word is different and then ends the loop.
                if (newWord != word)
                    checkSame = false;
            }
        }
    }
}