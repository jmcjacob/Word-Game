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
    public partial class GameEnter : Form
    {
        // New object created from the PlayerGame class.
        PlayerGame game = new PlayerGame();

        // Object reference that will be set from another form.
        public PlayerName name
        {
            get;
            set;
        }

        // Method that will run on form opening that will set all the components.
        public void onOpen()
        {
#if TEST
            Debug.WriteLine("GameEnter Opened with the name " + name.getPlayerName() + ".");
#endif
            InitializeComponent();
            WelcomeLable.Text = "Hello " + name.getPlayerName() + ",\nWhat game would you like to play?";
        }

        // Override method that will exit the application on form closing.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
#if TEST
            Debug.WriteLine("Exit button clicked, All processes ending.");
#endif
            Application.Exit();
        }

        // Methods for to display information when the player hovers there mouse over the buttons.
        private void GuessTheWordButton_MouseHover(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Displaying Guess the Word Text.");
#endif
            Information.Text = "Guess the word is a game where you will select diffrent letters in order to try and figure out the word. But be carful you will have a limited number of tries and on the harder difficulty a time limit.";
        }

        private void ConundrumButton_MouseHover(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Displaying Conundrum Text.");
#endif
            Information.Text = "In Conundrum you will be presented with a word that has been scrambled and you will have to figure out what word has been scrambled but you will have a limited number of tries and limited time.";
        }

        private void FillInTheBlanksButton_MouseHover(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Displaying Fill in the Blanks Text.");
#endif
            Information.Text = "In the game Fill in the Blanks you will be presented with a word with some of the letters removed you will have to guess what is the word. You will have a limited number of tries and limited time.";
        }

        // Methods for setting the game and going to the next form.
        private void GuessTheWordButton_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Set game to Guess the Word.");
#endif
            game.setSelectedGame(1);
            next();
        }

        private void ConundrumButton_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Set game to Conundrum.");
#endif
            game.setSelectedGame(2);
            next();
        }

        private void FillInTheBlanksButton_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Set game to Fill in the Blanks.");
#endif
            game.setSelectedGame(3);
            next();
        }

        // Method for going to the next form.
        void next()
        {
#if TEST
            Debug.WriteLine("Opening difficultyEnter with game choice " + game.getGameName() + ".");
#endif 
            DifficultyEnter difficulty = new DifficultyEnter();
            difficulty.game = game;
            difficulty.name = name;
            difficulty.onStart();
            this.Hide();
            difficulty.Show();
        }
    }
}