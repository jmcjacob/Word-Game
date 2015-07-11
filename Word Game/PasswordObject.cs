using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ionic.Zip;
using System.Windows.Forms;

namespace Word_Game
{
    class PasswordObject
    {
        // Variable for storing the password.
        public string password
        {
            get;
            set;
        }

        // Method for setting the password.
        public void setPassword()
        {
            // Using the object MemoryStream I can write the content of the text file to memory.
            using (var ms = new MemoryStream())
            {
                // Using a try I can catch any exceptions that there might be.
                try
                {
                    // Setting the zip file to an object so it can be edited.
                    using (ZipFile zip = ZipFile.Read("Words.zip"))
                    {
                        // This will get the content of the zipped file and set it into memory.
                        ZipEntry e = zip["Password.txt"];
                        e.ExtractWithPassword(ms, "01827711125");
                        ms.Position = 0;

                        // StreamReader will then read and set the contents of the memory to the object.
                        StreamReader sr = new StreamReader(ms);
                        password = sr.ReadToEnd();
                    }
                }
                // The catch will then catch the exception file not found as the two files Words.zip and Ionic.Zip.dll are required.
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File missing please make sure that Words.zip\n and Ionic.Zip.dll are in the same directory as Jacob's Word Game.", "Game Admin Tools");
                }
            }
        }

        // Method for returning the password.
        public string getPassword()
        {
            return password;
        }
    }
}
