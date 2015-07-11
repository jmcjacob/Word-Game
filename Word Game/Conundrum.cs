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
    public partial class Conundrum : Form
    {
        // Declares a new object from the ConundrumObject class.
        ConundrumObject conundrum = new ConundrumObject();

        // Object references that will be set from another form.
        public PlayerName name
        {
            get;
            set;
        }

        public PlayerGame game
        {
            get;
            set;
        }

        public PlayerDifficulty difficulty
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

        // Method that will run when the form is opened..
        public void onOpen()
        {
#if TEST
            Debug.WriteLine("Conundrum opened with difficulty choice " + difficulty.getDifficultyName() + ", game choice of " + game.getGameName() + " and the name " + name.getPlayerName() + ".");
#endif
            InitializeComponent();

            // Sets the label to include previous entered information.
            WelcomeLable.Text = name.getPlayerName() + " is playing\n" + game.getGameName() + " on " + difficulty.getDifficultyName() + " mode";

            // Loads the new game.
            newGame();
        }

        // Method to start a new game.
        void newGame()
        {
            // Sets the score for the game based on the difficulty the player selected.
            conundrum.setScore(difficulty.getSelectedDifficulty());
            ScoreLable.Text = "Tries: " + Convert.ToString(conundrum.getScore());

            // Sets the word that the player will have to unscramble.
            conundrum.setWord(difficulty.getSelectedDifficulty());
            conundrum.jumbleWord();
            NewWordLable.Text = conundrum.getNewWord();

            // Sets the timer for the game based on the difficulty the player selected.
            conundrum.setTimer(difficulty.getSelectedDifficulty());
            TimerLable.Text = "Time Remaining: " + Convert.ToString(conundrum.getTime());
            gameTimer.Enabled = true;
        }

        // Method that will run when the game ends.
        public void endGame()
        {
            // Creates a dialog box that will ask the player if they would like to play again.
            DialogResult dialog = MessageBox.Show("Would you like to play again?", "Jacob's Word Game", MessageBoxButtons.YesNo);

            // If the user says yes then the game will restart.
            if (dialog == DialogResult.Yes)
            {
#if TEST
                Debug.WriteLine("Resetting game.");
#endif
                playerWord.Text = "";
                newGame();
            }
            // If the player response with no the exitGame method will run.
            else
            {
#if TEST
                Debug.WriteLine("Exiting game.");
#endif
                conundrum.exitGame();
            }
        }

        // Method for when the game timer ticks.
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Method that will tick the timer.
            conundrum.tickTimer();
            TimerLable.Text = "Time Remaining: " + Convert.ToString(conundrum.getTime());

            // If the timer reaches 0 it will end the game.
            if (conundrum.getTime() == 0)
            {
#if TEST
                Debug.WriteLine("Timer now equal to zero starting end game sequence.");
#endif
                gameTimer.Enabled = false;
                MessageBox.Show("Sorry you have lost the Game.", "Jacob's Word Game");
                endGame();
            }
        }

        // Method for when the Enter Word button is clicked.
        private void EnterWord_Click(object sender, EventArgs e)
        {
            // Checks if the word entered by the player is the correct word.
            if (conundrum.checkCorrect(playerWord.Text))
            {
                // Adds up the score then feeds it back to the player then runs the endGame method.
                gameTimer.Enabled = false;
                conundrum.addScore(conundrum.getTime() / 5);
#if TEST
                Debug.WriteLine("Correct word has been entered now starting end game sequence with a score of " + conundrum.getScore() + ".");
#endif
                MessageBox.Show("Well done you have won the game with a score of " + Convert.ToString(conundrum.getScore()), "Jacob's Word Game");
                endGame();
            }
            // If the player word is incorrect it will then minus one to the score and flash the text red to indicate its incorrect.
            else
            {
#if TEST
                Debug.WriteLine("Incorrect word has been entered number of tries now set to " + (conundrum.getScore() - 1) + ".");
#endif
                conundrum.addScore(-1);
                ScoreLable.Text = "Tries: " + Convert.ToString(conundrum.getScore());
                NewWordLable.ForeColor = Color.Red;
                flashTimer.Enabled = true;

                // If the players score reaches 0 then end the game.
                if (conundrum.getScore() == 0)
                {
#if TEST
                    Debug.WriteLine("Number of tries now at 0, starting end game sequence.");
#endif
                    gameTimer.Enabled = false;
                    MessageBox.Show("Sorry you have lost the Game.\nThe word was " + conundrum.getWord() + ".", "Jacob's Word Game");
                    endGame();
                }
            }
        }

        // Method for each flash timer tick.
        private void flashTimer_Tick(object sender, EventArgs e)
        {
            // Makes the new word label finish flashing.
            NewWordLable.ForeColor = Color.Black;
            flashTimer.Enabled = false;
        }

        // Method for when the restart button is clicked and the the game restarts.
        private void RestartButton_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Resetting game.");
#endif
            playerWord.Text = "";
            newGame();
        }

        // Method for when the back button is clicked.
        private void BackButon_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Asking players if they want to go back.");
#endif
            // Asks the player if they are sure then restarts the application taking them back to the beginning.
            DialogResult dialog = MessageBox.Show("Would you like to go back?", "Jacob's Word Game", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
#if TEST
                Debug.WriteLine("Restarting the application.");
#endif
                Application.Restart();
        }
    }
}
