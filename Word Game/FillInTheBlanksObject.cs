using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    // Sets the class to public and inherits from the game class.
    public class FillInTheBlanksObject : Game
    {
        // Method to take letters from the word and set the new word.
        public void takeLetters(int difficulty)
        {
            // Sets the word to an array then takes letters based on the difficulty.
            char[] wordArray = word.ToCharArray();
            for (int i = 0; i < difficulty; i++)
            {
                Random rnd = new Random();
                int number = rnd.Next(0, wordArray.Length - 1);
                // Checks if the letter has already been taken.
                if (wordArray[number] == '?')
                    i--;
                else
                {
                    wordArray[number] = '?';
                }
            }
            // Sets the new string to as newWord.
            newWord = new string(wordArray);
        }
    }
}
