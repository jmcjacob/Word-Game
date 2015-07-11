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
    public partial class Fill_in_the_Blanks : Form
    {
        // Declares a new object from the FillInTheBlanksObject class.
        FillInTheBlanksObject fillInTheBlanks = new FillInTheBlanksObject();

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

        // Method that will run on form open.
        public void onOpen()
        {
#if TEST
            Debug.WriteLine("Fill in the Blanks opened with difficulty choice " + difficulty.getDifficultyName() + ", game choice of " + game.getGameName() + " and the name " + name.getPlayerName() + ".");
#endif
            // Sets the components of the form.
            InitializeComponent();
            WelcomeLable.Text = name.getPlayerName() + " is playing\n" + game.getGameName() + " on " + difficulty.getDifficultyName() + " mode";
            dropDowns();

            // Runs a new game instance.
            newGame();
        }

        // Method for running a new game.
        void newGame()
        {
            fillInTheBlanks.setScore(difficulty.getSelectedDifficulty());
            ScoreLable.Text = "Tries: " + Convert.ToString(fillInTheBlanks.getScore());

            fillInTheBlanks.setWord(difficulty.getSelectedDifficulty());
            fillInTheBlanks.takeLetters(difficulty.getSelectedDifficulty());
            NewWordLable.Text = fillInTheBlanks.getNewWord();

            fillInTheBlanks.setTimer(difficulty.getSelectedDifficulty());
            TimerLable.Text = "Time Remaining: " + Convert.ToString(fillInTheBlanks.getTime());
            gameTimer.Enabled = true;
        }

        // Method for setting the drop down boxes.
        public void dropDowns()
        {
            // Switch to only display the necessary drop down boxes for the selected difficulty.
            switch (difficulty.getSelectedDifficulty())
            {
                case 2:
                    Box1.Visible = true;
                    Box2.Visible = true;
                    break;
                case 3:
                    Box1.Visible = true;
                    Box2.Visible = true;
                    Box3.Visible = true;
                    break;
                default:
                    Box1.Visible = true;
                    break;
            }
        }

        // Method that will be run on the game ending.
        public void endGame()
        {
            // Creates a dialogue box that will ask the player if they would like to play again.
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
                fillInTheBlanks.exitGame();
            }
        }

        // Method for when the restart button is clicked to launch a new game.
        private void RestartButton_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Resetting game.");
#endif
            newGame();
        }

        // Method for when the back button is clicked.
        private void BackButon_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Asking players if they want to go back.");
#endif
            // Message box that will ask the player if they would like to go back.
            DialogResult dialog = MessageBox.Show("Would you like to go back?", "Jacob's Word Game", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
#if TEST
                Debug.WriteLine("Restarting the application.");
#endif
                Application.Restart();
            }
        }

        // Method for when the game timer has been clicked.
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Method that will tick the timer.
            fillInTheBlanks.tickTimer();
            TimerLable.Text = "Time Remaining: " + Convert.ToString(fillInTheBlanks.getTime());
            
            // If the timer reaches 0 it will end the game.
            if (fillInTheBlanks.getTime() == 0)
            {
#if TEST
                Debug.WriteLine("Timer now equal to zero starting end game sequence.");
#endif
                gameTimer.Enabled = false;
                MessageBox.Show("Sorry you have lost the Game.", "Jacob's Word Game");
                endGame();
            }
        }

        // Method for flash timer tick
        private void flashTimer_Tick(object sender, EventArgs e)
        {
            // Makes the new word label finish flashing.
            NewWordLable.ForeColor = Color.Black;
            flashTimer.Enabled = false;
        }

        // Method for when the Enter Word button is clicked.
        private void EnterWord_Click(object sender, EventArgs e)
        {
            // Sets the list of missing letters from the word.
            char[] array = fillInTheBlanks.getNewWord().ToCharArray();
            int boxNumber = 1;
            int charNum = 0;

            // Goes through each box and adds the players letters to the word.
            foreach (char i in array)
            {
                if (i == '?')
                {
                    if (boxNumber == 1)
                    {
                        if (Box1.Text != "")
                        {
                            array[charNum] = Convert.ToChar(Box1.Text);
                            boxNumber++;
                        }
                    }
                    else if (boxNumber == 2)
                    {
                        if (Box2.Text != "")
                        {
                            array[charNum] = Convert.ToChar(Box2.Text);
                            boxNumber++;
                        }
                    }
                    else if (boxNumber == 3)
                    {
                        if (Box3.Text != "")
                            array[charNum] = Convert.ToChar(Box3.Text);
                    }
                }
                charNum++;
            }

            // Sets the players word and checks if players word is correct.
            string playerWord = new string(array);
            if (fillInTheBlanks.checkCorrect(playerWord))
            {
                // Ends the game and informs of victory.
                gameTimer.Enabled = false;
                fillInTheBlanks.addScore(fillInTheBlanks.getTime() / 5);
#if TEST
                Debug.WriteLine("Correct word has been entered now starting end game sequence with a score of " + fillInTheBlanks.getScore() + ".");
#endif
                MessageBox.Show("Well done you have won the game with a score of " + Convert.ToString(fillInTheBlanks.getScore()), "Jacob's Word Game");
                endGame();
            }
            // If the player is wrong.
            else
            {
#if TEST
                Debug.WriteLine("Incorrect word has been entered number of tries now set to " + (fillInTheBlanks.getScore() - 1) + ".");
#endif
                // Minuses one to the score and indicates that the player was wrong.
                fillInTheBlanks.addScore(-1);
                ScoreLable.Text = "Tries: " + Convert.ToString(fillInTheBlanks.getScore());
                NewWordLable.ForeColor = Color.Red;
                flashTimer.Enabled = true;
            }
            // If the player's score is equal to zero they will lose the game.
            if (fillInTheBlanks.getScore() == 0)
            {
#if TEST
                Debug.WriteLine("Number of tries now at 0, starting end game sequence.");
#endif
                // The game will end.
                gameTimer.Enabled = false;
                MessageBox.Show("Sorry you have lost the Game.\nThe word was " + fillInTheBlanks.getWord() + ".", "Jacob's Word Game");
                endGame();
            }
        }
    }
}