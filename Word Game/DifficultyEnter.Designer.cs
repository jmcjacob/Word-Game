namespace Word_Game
{
    partial class DifficultyEnter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DifficultyEnter));
            this.WelcomeLable = new System.Windows.Forms.Label();
            this.EasyButton = new System.Windows.Forms.Button();
            this.MediumButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // WelcomeLable
            // 
            this.WelcomeLable.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLable.Location = new System.Drawing.Point(12, 9);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(260, 51);
            this.WelcomeLable.TabIndex = 0;
            this.WelcomeLable.Text = "So ...................., \r\nYour playing ...................., \r\nWhat difficulty d" +
    "o you want to play?";
            this.WelcomeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EasyButton
            // 
            this.EasyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyButton.Location = new System.Drawing.Point(15, 63);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(257, 26);
            this.EasyButton.TabIndex = 1;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = true;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            this.EasyButton.MouseHover += new System.EventHandler(this.EasyButton_MouseHover);
            // 
            // MediumButton
            // 
            this.MediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediumButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumButton.Location = new System.Drawing.Point(15, 95);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(257, 26);
            this.MediumButton.TabIndex = 2;
            this.MediumButton.Text = "Medium";
            this.MediumButton.UseVisualStyleBackColor = true;
            this.MediumButton.Click += new System.EventHandler(this.MediumButton_Click);
            this.MediumButton.MouseHover += new System.EventHandler(this.MediumButton_MouseHover);
            // 
            // HardButton
            // 
            this.HardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardButton.Location = new System.Drawing.Point(15, 127);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(257, 26);
            this.HardButton.TabIndex = 3;
            this.HardButton.Text = "Hard";
            this.HardButton.UseVisualStyleBackColor = true;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            this.HardButton.MouseHover += new System.EventHandler(this.HardButton_MouseHover);
            // 
            // Information
            // 
            this.Information.Enabled = false;
            this.Information.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(12, 159);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(257, 42);
            this.Information.TabIndex = 4;
            this.Information.Text = "Move your mouse over a difficulty to find out more.";
            // 
            // DifficultyEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.HardButton);
            this.Controls.Add(this.MediumButton);
            this.Controls.Add(this.EasyButton);
            this.Controls.Add(this.WelcomeLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DifficultyEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jacob\'s Word Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLable;
        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Button MediumButton;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.RichTextBox Information;

    }
}