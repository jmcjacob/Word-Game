#define TEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using Ionic.Zip;
using System.Diagnostics;

namespace Word_Game
{
    // The class is set to public and inherits off PlayerScore
    public class Game : PlayerScore
    {
        // The variables are declared.
        public string word
        {
            get;
            set;
        }

        public string newWord
        {
            get;
            set;
        }

        // The method to set the word based on difficulty from a text file.
        public void setWord(int difficulty)
        {
            // Using a memory stream I can read from a file.
            using (var ms = new MemoryStream())
            {
                // Using a try I can catch any exceptions that there might be.
                try
                {
                    // Accessing the zip file so that I can read the text file.
                    using (ZipFile zip = ZipFile.Read("Words.zip"))
                    {
                        // Gets the text file from the zip file.
                        ZipEntry e = zip["Words.txt"];
                        e.ExtractWithPassword(ms, "01827711125");
                        ms.Position = 0;

                        // Reads the text from the text file.
                        StreamReader sr = new StreamReader(ms);
                        string text = sr.ReadToEnd();

                        // Splits the text into an array of three sections and selects on based on difficulty.
                        string[] textDifficulty = text.Split('/');
                        string words = textDifficulty[difficulty - 1];

                        // Splits new text into words then selects a word based a random number.
                        string[] wordList = words.Split(' ');
                        Random rnd = new Random();
                        word = wordList[rnd.Next(0, wordList.Length)];
                    }
                }
                // The catch will then catch the exception file not found as the two files Words.zip and Ionic.Zip.dll are required.
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File missing please make sure that Words.zip\n and Ionic.Zip.dll are in the same directory as Jacob's Word Game.", "Jacob's Word Game");
                }
            }
        }

        // This method will return the word.
        public string getWord()
        {
            return word;
        }

        // This method will return the new word.
        public string getNewWord()
        {
            return newWord;
        }

        // This method will check if the player's word is correct.
        public bool checkCorrect(string playerWord)
        {
            // The word is set to be all upper-case.
            bool correct = false;
            playerWord = playerWord.ToUpper();

            // The word is then checked if equal.
            if (playerWord == word)
                correct = true;
            return correct;
        }

        // This method will exit the game.
        public void exitGame()
        {
            // Create a dialogue box that asks user if they would like to quit.
            DialogResult dialogResult2 = MessageBox.Show("Would you like to quit?", "Jacob's Word Game", MessageBoxButtons.YesNo);

            // If they say yes it exits the application.
            if (dialogResult2 == DialogResult.Yes)
            {
#if TEST
                Debug.WriteLine("Exiting the application.");
#endif
                Application.Exit();
            }

            // If they say no it restarts the application.
            else if (dialogResult2 == DialogResult.No)
            {

#if TEST
                Debug.WriteLine("Restarting the application.");
#endif
                Application.Restart();
            }
        }
    }
}