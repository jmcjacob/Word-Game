#define TEST
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Word_Game
{
    public partial class AdminTools : Form
    {
        // Creates a new object from the admin class.
        Admin admin = new Admin();

        // Method that that runs on form runs.
        public AdminTools()
        {
#if TEST
            Debug.WriteLine("Opened AdminTools.");
#endif
            // Code will set the components of the form.
            InitializeComponent();
            admin.getWords();
            admin.listOfWords(DeleteBox);
        }

        // Override method that will exit application on form close.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
#if TEST
            Debug.WriteLine("Exit button clicked, All processes ending.");
#endif
            Application.Exit();
        }

        // Method for when the Delete Word button is clicked.
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Checks if a word has been selected.
            if (DeleteBox.Text != "")
            {
#if TEST
                Debug.WriteLine("The word " + DeleteBox.Text + " has been deleted.");
#endif
                // The selected word is then deleted from the text file.
                MessageBox.Show("The Word " + DeleteBox.Text + " has been deleted.", "Game Admin Tools");
                admin.removeWord(DeleteBox.Text);
                admin.listOfWords(DeleteBox);
            }
            else
            {
#if TEST
                Debug.WriteLine("Word not selected.");
#endif
                MessageBox.Show("Please select a word to delete.", "Game Admin Tools");
            }
        }

        // Method for when the Add Word button is clicked.
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Checks if the user has selected a difficulty for the new word.
            if (difficultySelect.Text != "")
            {
                // Checks if the word that has been entered is valid.
                if (admin.checkValid(wordEnter.Text))
                {
                    // Sets the difficulty and gives it a value.
                    int difficulty = 0;
                    switch (difficultySelect.Text)
                    {
                        case "Easy":
                            difficulty = 0;
                            break;
                        case "Medium":
                            difficulty = 1;
                            break;
                        case "Hard":
                            difficulty = 2;
                            break;
                        default:
                            break;
                    }
                    // Adds the word to the text file.
#if TEST
                    Debug.WriteLine("Added " + wordEnter.Text.ToUpper() + " to the list of words.");
#endif
                    admin.addWord(difficulty, wordEnter.Text.ToUpper());
                    admin.listOfWords(DeleteBox);
                    MessageBox.Show("The Word " + wordEnter.Text.ToUpper() + " has been added.", "Game Admin Tools");
                    wordEnter.Text = "";
                }
                else
                {
#if TEST
                    Debug.WriteLine("Valid word not provided.");
#endif
                    // Asks the user to enter a valid word.
                    wordEnter.Text = "";
                    MessageBox.Show("Please Enter a valid word.", "Game Admin Tools");
                }
            }
            else
            {
#if TEST
                Debug.WriteLine("Difficulty not selected.");
#endif
                // Asks the user to select a difficulty.
                MessageBox.Show("Please Select a difficulty.", "Game Admin Tools");
            }
        }

        // Method for when the Back button is clicked.
        private void Back_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Restarting application.");
#endif
            // Restarts the application so if reruns to the beginning.
            Application.Restart();
        }
    }
}
