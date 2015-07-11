using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Ionic.Zip;

namespace Word_Game
{
    class Admin
    {
        // This is the deceleration of the string that will store the text file content.
        public string text
        {
            get;
            set;
        }

        // This is the method that will read the zipped text file and set the text inside of it to the object.
        public void getWords()
        {
            // Using the object MemoryStream I can write the content of the text file to memory.
            using (MemoryStream ms = new MemoryStream())
            {
                // Using a try I can catch any exceptions that there might be.
                try
                {
                    // Setting the zip file to an object so it can be edited.
                    using (ZipFile zip = ZipFile.Read("Words.zip"))
                    {
                        // This will get the content of the zipped file and set it into memory.
                        ZipEntry e = zip["Words.txt"];
                        zip.Password = "01827711125";
                        e.Extract(ms);
                        ms.Position = 0;

                        // StreamReader will then read and set the contents of the memory to the object.
                        using (StreamReader sr = new StreamReader(ms))
                        {
                            text = sr.ReadToEnd();
                        }
                    }
                }
                // The catch will then catch the exception file not found as the two files Words.zip and Ionic.Zip.dll are required.
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File missing please make sure that Words.zip and Ionic.Zip.dll\nare in the same directory as Jacob's Word Game.", "Game Admin Tools");
                }
            }
        }

        // This is the method for setting the contents of a combo box to be a list of words extracted from the text inside the object.
        public void listOfWords(ComboBox box)
        {
            // Clearing the box is required so it can be updated.
            box.Items.Clear();

            // This splits the text into an sting array of each individual word.
            string[] words = text.Replace("/", " ").Split(' ');

            // This will then insert each word of the array into the combo box.
            int j = 0;
            foreach (string word in words)
            {
                box.Items.Insert(j, word);
                j++;
            }
        }

        // This is the method for removing words from the zipped text file.
        public void removeWord(string word)
        {
            // This sets the text with the word removed.
            text = text.Replace(word + " ", string.Empty);
            text = text.Replace(" " + word, string.Empty);

            // Using a try I can catch any exceptions that there might be.
            try
            {
                // Setting the zip file to an object so it can be edited.
                using (ZipFile zip = ZipFile.Read("Words.zip"))
                {
                    // This will update the text file to have the altered text file inside.
                    zip.Password = "01827711125";
                    zip.UpdateEntry("Words.txt", text);
                    zip.Save();
                }
            }
            // The catch will then catch the exception file not found as the two files Words.zip and Ionic.Zip.dll are required.
            catch (FileNotFoundException)
            {
                MessageBox.Show("File missing please make sure that Words.zip\n and Ionic.Zip.dll are in the same directory as Jacob's Word Game.", "Game Admin Tools");
            }
        }

        // This is the method for adding words to the zipped text file.
        public void addWord(int difficulty, string word)
        {
            // This will set a string of words for the selected difficulty
            string[] wordList = text.Split('/');
            string words = wordList[difficulty];
            words = words + " " + word;
            
            // Then adds the word into the a string.
            wordList[difficulty] = words;
            text = string.Join("/", wordList);

            // Using a try I can catch any exceptions that there might be.
            try
            {
                // Setting the zip file to an object so it can be edited.
                using (ZipFile zip = ZipFile.Read("Words.zip"))
                {
                    // Edits the txt file that contains the words then updates the zip file.
                    zip.Password = "01827711125";
                    zip.UpdateEntry("Words.txt", text);
                    zip.Save();
                }
            }
            // The catch will then catch the exception file not found as the two files Words.zip and Ionic.Zip.dll are required.
            catch (FileNotFoundException)
            {
                MessageBox.Show("File missing please make sure that Words.zip\n and Ionic.Zip.dll are in the same directory as Jacob's Word Game.", "Game Admin Tools");
            }
        }

        // This is the method for checking is a entered word is valid.
        public bool checkValid(string word)
        {
            bool check = true;

            // Checks if the word length is acceptable.
            if (word.Length <= 1 || word.Length >= 20)
                check = false;
            else
            {
                // Checks that each character is a letter.
                foreach (char i in word)
                {
                    if (letter(i)) { }
                    else check = false;
                }
            }
            return check;
        }

        protected bool letter(char i)
        {
            bool check = false;
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            foreach(char j in letters)
            {
                if (char.ToLower(i) == j)
                    check = true;
            }
            return check;
        }
    }
}