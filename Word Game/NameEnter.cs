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
    public partial class NameEnter : Form
    {
        // New object declared based on the PlayerName class.
        PlayerName name = new PlayerName();

        // Method that runs on the form open that sets the components.
        public NameEnter()
        {
            InitializeComponent();
        }

        // Method for when admin button is clicked.
        private void admin_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Opening password from Admin button.");
#endif
            // Launch the EnterPassword form.
            PasswordEnter password = new PasswordEnter();
            this.Hide();
            password.Show();
        }

        // Method for when the name button is clicked.
        private void nameButton_Click(object sender, EventArgs e)
        {
            // Sets the player name and checks if the name is valid.
            name.setPlayerName(playerName.Text);
            if(name.checkValidName())
            {
#if TEST
                Debug.WriteLine("Opening GameEnter from NameEnter button with the name " + name.getPlayerName() + ".");
#endif
                // Opens the next form.
                GameEnter game = new GameEnter();
                game.name = name;
                game.onOpen();
                this.Hide();
                game.Show();
            }
            // Informs the user that the name entered is not valid.
            else
            {
#if TEST
                Debug.WriteLine("Name Entered not valid, GameEnter not opened.");
#endif
                playerName.Text = "";
                MessageBox.Show("Please enter a valid name.", "Jacob's Word Game");
            }
        }
    }
}
