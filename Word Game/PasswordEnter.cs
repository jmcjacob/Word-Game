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
    public partial class PasswordEnter : Form
    {
        // Object declared based on the passwordObject.
        PasswordObject password = new PasswordObject();

        // That that will run when the form opens and will set all the components.
        public PasswordEnter()
        {
            InitializeComponent();
#if TEST
            Debug.WriteLine("Password Enter opened.");
#endif
        }

        // Method that will run when the enter password button is clicked.
        private void EnterPassword_Click(object sender, EventArgs e)
        {
            // Checks if the entered password is correct and opens the next form.
            password.setPassword();
            if (userPassword.Text == password.getPassword())
            {
#if TEST
                Debug.WriteLine("Opening AdminTools.");
#endif
                AdminTools admin = new AdminTools();
                this.Hide();
                admin.Show();
            }
            // Display a message telling the user the password is wrong.
            else
            {
#if TEST
                Debug.WriteLine("Wrong password not directing to AdminTools form.");
#endif
                MessageBox.Show("Wrong password\nEnter another", "Game Admin Tools");
                userPassword.Text = "";
            }
        }

        // Method to restart the application on button clicked.
        private void Back_Click(object sender, EventArgs e)
        {
#if TEST
            Debug.WriteLine("Restarting application.");
#endif
            Application.Restart();
        }

        // Override method to exit the application.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
#if TEST
            Debug.WriteLine("Exit button clicked, All processes ending.");
#endif
            Application.Exit();
        }
    }
}
