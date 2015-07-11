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
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Word_Game
{
    public partial class Guess_The_Word : Form
    {
        // Creates a new object based on the guessTheWordObject class.
        GuessTheWordObject guessTheWord = new GuessTheWordObject();
 
        // Object references set from other forms.
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

        // Override method that exits the application on form closing.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
#if TEST
            Debug.WriteLine("Exit button clicked, All processes ending.");
#endif
            Application.Exit();
        }

        // Method that will run on form opening that will set all the components.
        public void onOpen()
        {
#if TEST
            Debug.WriteLine("Guess the Word opened with difficulty choice " + difficulty.getDifficultyName() + ", game choice of " + game.getGameName() + " and the name " + name.getPlayerName() + ".");
#endif
            InitializeComponent();
            WelcomeLable.Text = name.getPlayerName() + " is playing\n" + game.getGameName() + " on " + difficulty.getDifficultyName() + " mode";
            newGame();
        }

        // Methods for starting a new game.
        void newGame()
        {
            //Sets the words.
            guessTheWord.setWord(difficulty.getSelectedDifficulty());
            guessTheWord.setNewWord();
            NewWordLable.Text = guessTheWord.getNewWord();

            //Sets the timer and the score based on difficulty.
            guessTheWord.setTimer(difficulty.getSelectedDifficulty());
            TimerLable.Text = "Time Remaining: " + Convert.ToString(guessTheWord.getTime());
            guessTheWord.setScore(difficulty.getSelectedDifficulty());
            
            // Disables the timer if difficulty set to easy.
            if (difficulty.getSelectedDifficulty() == 1)
            {
                guessTheWord.addScore(guessTheWord.getScore());
                TimerLable.Visible = false;
                gameTimer.Enabled = false;
            }
            else
                gameTimer.Enabled = true;
            ScoreLable.Text = "Tries: " + Convert.ToString(guessTheWord.getScore());

            resetButtons();
        }

        // Method to end the game.
        public void endGame()
        {
            // Message box asking if the player wants to play again.
            DialogResult dialog = MessageBox.Show("Would you like to play again?", "Jacob's Word Game", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
#if TEST
                Debug.WriteLine("Resetting game.");
#endif
                newGame();
            }
            else if (dialog == DialogResult.No)
            {
#if TEST
                Debug.WriteLine("Exiting game.");
#endif
                guessTheWord.exitGame();
            }
        }

        // Method that ticks the game timer.
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Ticks the timer
            guessTheWord.tickTimer();
            TimerLable.Text = "Time Remaining: " + Convert.ToString(guessTheWord.getTime());

            // If the timer equals zero the game ends.
            if(guessTheWord.getTime() == 0)
            {
#if TEST
                Debug.WriteLine("Timer now equal to zero starting end game sequence.");
#endif
                gameTimer.Enabled = false;
                MessageBox.Show("Sorry you have lost the Game.", "Jacob's Word Game");
                endGame();
            }
        }

        // Method to tick flash timer.
        private void flashTimer_Tick(object sender, EventArgs e)
        {
            // Resets the flash timer.
            NewWordLable.ForeColor = Color.Black;
            flashTimer.Enabled = false;
        }

        // Method for when a button is clicked.
        private void button(object sender, EventArgs e)
        {
            // Try makes it so I can catch any errors.
            try
            {
                // Sets the button to equal the button clicked.
                Button button = (Button)sender;
                button.Enabled = false;

                // Checks if the character is present in the word.
                if (guessTheWord.checkChar(Convert.ToChar(button.Text)))
                {
#if TEST
                    Debug.WriteLine("Correct button has been pressed and word now set to " + guessTheWord.newWord);
#endif
                    // Sets the new word label.
                    NewWordLable.Text = guessTheWord.getNewWord();

                    // Checks if the new word equals the original word.
                    if (NewWordLable.Text == Regex.Replace(guessTheWord.getWord(), ".{0}", "$0 "))
                    {
                        // Ends the game.
                        gameTimer.Enabled = false;
                        if (difficulty.getSelectedDifficulty() != 1)
                            guessTheWord.addScore(guessTheWord.getTime() / 5);
#if TEST
                        Debug.WriteLine("Correct word has been entered now starting end game sequence with a score of " + guessTheWord.getScore() + ".");
#endif
                        MessageBox.Show("Well done you have won the game with a score of " + Convert.ToString(guessTheWord.getScore()));
                        endGame();
                    }
                }
                // If the player is wrong.
                else
                {
#if TEST
                    Debug.WriteLine("Incorrect button has been selected number of tries now set to " + (guessTheWord.getScore() - 1) + ".");
#endif
                    // Tells the player is wrong and minuses from there score.
                    guessTheWord.addScore(-1);
                    ScoreLable.Text = "Tries: " + Convert.ToString(guessTheWord.getScore());
                    NewWordLable.ForeColor = Color.Red;
                    flashTimer.Enabled = true;
                }
                // If the score is equal to 9.
                if (guessTheWord.getScore() == 0)
                {
#if TEST
                    Debug.WriteLine("Number of tries now at 0, starting end game sequence.");
#endif
                    // End the game.
                    gameTimer.Enabled = false;
                    MessageBox.Show("Sorry you have lost the Game.\nThe word was " + guessTheWord.getWord() + ".", "Jacob's Word Game");
                    endGame();
                }
            }
            // Catch allows the exception be caught.
            catch (System.InvalidCastException) 
            {
                MessageBox.Show("too fast");
            }
        }

        // Method for when the back button is clicked.
        private void BackButon_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Asking players if they want to go back.");
#endif
            // Message box asks if the player wants to go back.
            DialogResult dialog = MessageBox.Show("Would you like to go back?", "Jacob's Word Game", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
#if TEST
                Debug.WriteLine("Restarting the application.");
#endif
                Application.Restart();
            }
        }

        // Method for when the restart button is clicked.
        private void RestartButton_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Resetting game.");
#endif
            newGame();
        }

        void resetButtons()
        {
            AButton.Enabled = true;
            BButton.Enabled = true;
            CButton.Enabled = true;
            DButton.Enabled = true;
            EButton.Enabled = true;
            FButton.Enabled = true;
            GButton.Enabled = true;
            HButton.Enabled = true;
            IButton.Enabled = true;
            JButton.Enabled = true;
            KButton.Enabled = true;
            LButton.Enabled = true;
            MButton.Enabled = true;
            NButton.Enabled = true;
            OButton.Enabled = true;
            PButton.Enabled = true;
            QButton.Enabled = true;
            RButton.Enabled = true;
            SButton.Enabled = true;
            TButton.Enabled = true;
            UButton.Enabled = true;
            VButton.Enabled = true;
            WButton.Enabled = true;
            XButton.Enabled = true;
            YButton.Enabled = true;
            ZButton.Enabled = true;
        }
    }
}
