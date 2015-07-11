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
    public partial class DifficultyEnter : Form
    {
        // Declares a new object from the PlayerDifficulty class.
        PlayerDifficulty difficulty = new PlayerDifficulty();

        //Object references that will be set from another form.
        public PlayerGame game
        {
            get;
            set;
        }

        public PlayerName name
        {
            get;
            set;
        }

        // Override method that will exit the application on form close.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
#if TEST
            Debug.WriteLine("Exit button clicked, All processes ending.");
#endif
            Application.Exit();
        }

        // Method that will run on form open.
        public void onStart()
        {
#if TEST
            Debug.WriteLine("difficultyEnter opened with game choice of " + game.getGameName() + " and the name " + name.getPlayerName() + ".");
#endif
            InitializeComponent();

            // The label is set to include information.
            WelcomeLable.Text = "So " + name.getPlayerName() + ",\nYou're playing " + game.getGameName() +  ".\nWhat difficulty do you want to play?";
        }

        // Method for when the mouse is hovering over the medium button so that information about the difficulty is displayed.
        private void MediumButton_MouseHover(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Displaying Medium Text.");
#endif
            Information.Text = "You will have a medium sized word with a limited number of tires and a time limit.";
        }

        // Method for when the mouse is hovering over the hard button so that information about the difficulty is displayed.
        private void HardButton_MouseHover(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Displaying Hard Text.");
#endif
            Information.Text = "You will have a large word with a limited number of tries and a time limit.";
        }

        // Method for when the mouse is hovering over the easy button so that information about the difficulty is displayed.
        private void EasyButton_MouseHover(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Displaying Easy Text.");
#endif
            Information.Text = "You will be given a smaller word and the time limit will be removed.";
        }

        // Method for when the easy button is clicked.
        private void EasyButton_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Set difficulty to Easy.");
#endif
            difficulty.setSelectedDifficulty(1);
            next(game.getSelctedGame());
        }

        // Method for when the medium button is clicked.
        private void MediumButton_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Set difficulty to Medium.");
#endif
            difficulty.setSelectedDifficulty(2);
            next(game.getSelctedGame());
        }

        // Method for when the hard button is clicked.
        private void HardButton_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Set difficulty to Hard.");
#endif
            difficulty.setSelectedDifficulty(3);
            next(game.getSelctedGame());
        }

        // Method for loading the game based on the 
        void next(int selectedGame)
        {
            switch(selectedGame)
            {
                case 1:
#if TEST
                    Debug.WriteLine("Opening Guess The Word with difficulty choice " + difficulty.getDifficultyName() + ".");
#endif
                    // Loads game according to the players choice.
                    Guess_The_Word guessTheWord = new Guess_The_Word();

                    // Sets the objects in the game.
                    guessTheWord.name = name;
                    guessTheWord.game = game;
                    guessTheWord.difficulty = difficulty;

                    // Opens the game form closing the previous form.
                    guessTheWord.onOpen();
                    this.Hide();
                    guessTheWord.Show();
                    break;
                case 2:
#if TEST
                    Debug.WriteLine("Opening Conundrum with difficulty choice " + difficulty.getDifficultyName() + ".");
#endif
                    Conundrum conumdrum = new Conundrum();
                    conumdrum.name = name;
                    conumdrum.game = game;
                    conumdrum.difficulty = difficulty;
                    conumdrum.onOpen();
                    this.Hide();
                    conumdrum.Show();
                    break;

                case 3:
#if TEST
                    Debug.WriteLine("Opening Fill in the Blanks with difficulty choice " + difficulty.getDifficultyName() + ".");
#endif
                    Fill_in_the_Blanks fillInTheBlanks = new Fill_in_the_Blanks();
                    fillInTheBlanks.name = name;
                    fillInTheBlanks.game = game;
                    fillInTheBlanks.difficulty = difficulty;
                    fillInTheBlanks.onOpen();
                    this.Hide();
                    fillInTheBlanks.Show();
                    break;
                default:
                    break;
            }
            
        }
    }
}