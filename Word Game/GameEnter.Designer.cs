namespace Word_Game
{
    partial class GameEnter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameEnter));
            this.Information = new System.Windows.Forms.RichTextBox();
            this.GuessTheWordButton = new System.Windows.Forms.Button();
            this.ConundrumButton = new System.Windows.Forms.Button();
            this.FillInTheBlanksButton = new System.Windows.Forms.Button();
            this.WelcomeLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Information.Enabled = false;
            this.Information.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(12, 133);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(286, 71);
            this.Information.TabIndex = 0;
            this.Information.Text = "Move your mouse over a game to find out more.";
            // 
            // GuessTheWordButton
            // 
            this.GuessTheWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuessTheWordButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessTheWordButton.Location = new System.Drawing.Point(13, 46);
            this.GuessTheWordButton.Name = "GuessTheWordButton";
            this.GuessTheWordButton.Size = new System.Drawing.Size(285, 23);
            this.GuessTheWordButton.TabIndex = 1;
            this.GuessTheWordButton.Text = "Guess The Word!";
            this.GuessTheWordButton.UseVisualStyleBackColor = true;
            this.GuessTheWordButton.Click += new System.EventHandler(this.GuessTheWordButton_Click);
            this.GuessTheWordButton.MouseHover += new System.EventHandler(this.GuessTheWordButton_MouseHover);
            // 
            // ConundrumButton
            // 
            this.ConundrumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConundrumButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConundrumButton.Location = new System.Drawing.Point(12, 75);
            this.ConundrumButton.Name = "ConundrumButton";
            this.ConundrumButton.Size = new System.Drawing.Size(286, 23);
            this.ConundrumButton.TabIndex = 2;
            this.ConundrumButton.Text = "Conundrum!";
            this.ConundrumButton.UseVisualStyleBackColor = true;
            this.ConundrumButton.Click += new System.EventHandler(this.ConundrumButton_Click);
            this.ConundrumButton.MouseHover += new System.EventHandler(this.ConundrumButton_MouseHover);
            // 
            // FillInTheBlanksButton
            // 
            this.FillInTheBlanksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillInTheBlanksButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillInTheBlanksButton.Location = new System.Drawing.Point(12, 104);
            this.FillInTheBlanksButton.Name = "FillInTheBlanksButton";
            this.FillInTheBlanksButton.Size = new System.Drawing.Size(286, 23);
            this.FillInTheBlanksButton.TabIndex = 3;
            this.FillInTheBlanksButton.Text = "Fill in the Blanks!";
            this.FillInTheBlanksButton.UseVisualStyleBackColor = true;
            this.FillInTheBlanksButton.Click += new System.EventHandler(this.FillInTheBlanksButton_Click);
            this.FillInTheBlanksButton.MouseHover += new System.EventHandler(this.FillInTheBlanksButton_MouseHover);
            // 
            // WelcomeLable
            // 
            this.WelcomeLable.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLable.Location = new System.Drawing.Point(9, 9);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(296, 34);
            this.WelcomeLable.TabIndex = 4;
            this.WelcomeLable.Text = "Hello ...................., \r\nWhat game would you like to play?";
            this.WelcomeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(310, 216);
            this.Controls.Add(this.WelcomeLable);
            this.Controls.Add(this.FillInTheBlanksButton);
            this.Controls.Add(this.ConundrumButton);
            this.Controls.Add(this.GuessTheWordButton);
            this.Controls.Add(this.Information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jacob\'s Word Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Information;
        private System.Windows.Forms.Button GuessTheWordButton;
        private System.Windows.Forms.Button ConundrumButton;
        private System.Windows.Forms.Button FillInTheBlanksButton;
        private System.Windows.Forms.Label WelcomeLable;
    }
}