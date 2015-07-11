namespace Word_Game
{
    partial class Conundrum
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conundrum));
            this.NewWordLable = new System.Windows.Forms.Label();
            this.WelcomeLable = new System.Windows.Forms.Label();
            this.playerWord = new System.Windows.Forms.TextBox();
            this.ScoreLable = new System.Windows.Forms.Label();
            this.TimerLable = new System.Windows.Forms.Label();
            this.EnterWord = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.BackButon = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.flashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // NewWordLable
            // 
            this.NewWordLable.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWordLable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewWordLable.Location = new System.Drawing.Point(5, 67);
            this.NewWordLable.Name = "NewWordLable";
            this.NewWordLable.Size = new System.Drawing.Size(312, 42);
            this.NewWordLable.TabIndex = 0;
            this.NewWordLable.Text = "THISISALONGWORD";
            this.NewWordLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeLable
            // 
            this.WelcomeLable.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLable.Location = new System.Drawing.Point(12, 9);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(293, 35);
            this.WelcomeLable.TabIndex = 1;
            this.WelcomeLable.Text = ".................... is playing,\r\n .................... on .......... mode";
            this.WelcomeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerWord
            // 
            this.playerWord.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWord.Location = new System.Drawing.Point(12, 112);
            this.playerWord.Name = "playerWord";
            this.playerWord.Size = new System.Drawing.Size(293, 45);
            this.playerWord.TabIndex = 2;
            this.playerWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScoreLable
            // 
            this.ScoreLable.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLable.Location = new System.Drawing.Point(12, 44);
            this.ScoreLable.Name = "ScoreLable";
            this.ScoreLable.Size = new System.Drawing.Size(75, 23);
            this.ScoreLable.TabIndex = 3;
            this.ScoreLable.Text = "Tries: 99";
            // 
            // TimerLable
            // 
            this.TimerLable.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLable.Location = new System.Drawing.Point(180, 44);
            this.TimerLable.Name = "TimerLable";
            this.TimerLable.Size = new System.Drawing.Size(125, 23);
            this.TimerLable.TabIndex = 4;
            this.TimerLable.Text = "Time Remaining: 99";
            this.TimerLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EnterWord
            // 
            this.EnterWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterWord.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterWord.Location = new System.Drawing.Point(12, 163);
            this.EnterWord.Name = "EnterWord";
            this.EnterWord.Size = new System.Drawing.Size(227, 53);
            this.EnterWord.TabIndex = 5;
            this.EnterWord.Text = "Enter Text";
            this.EnterWord.UseVisualStyleBackColor = true;
            this.EnterWord.Click += new System.EventHandler(this.EnterWord_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Location = new System.Drawing.Point(248, 163);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(57, 23);
            this.RestartButton.TabIndex = 6;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // BackButon
            // 
            this.BackButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButon.Location = new System.Drawing.Point(248, 193);
            this.BackButon.Name = "BackButon";
            this.BackButon.Size = new System.Drawing.Size(57, 23);
            this.BackButon.TabIndex = 7;
            this.BackButon.Text = "Back";
            this.BackButon.UseVisualStyleBackColor = true;
            this.BackButon.Click += new System.EventHandler(this.BackButon_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // flashTimer
            // 
            this.flashTimer.Interval = 300;
            this.flashTimer.Tick += new System.EventHandler(this.flashTimer_Tick);
            // 
            // Conundrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(320, 230);
            this.Controls.Add(this.BackButon);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.EnterWord);
            this.Controls.Add(this.TimerLable);
            this.Controls.Add(this.ScoreLable);
            this.Controls.Add(this.playerWord);
            this.Controls.Add(this.WelcomeLable);
            this.Controls.Add(this.NewWordLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Conundrum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jacob\'s Word Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewWordLable;
        private System.Windows.Forms.Label WelcomeLable;
        private System.Windows.Forms.TextBox playerWord;
        private System.Windows.Forms.Label ScoreLable;
        private System.Windows.Forms.Label TimerLable;
        private System.Windows.Forms.Button EnterWord;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button BackButon;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer flashTimer;
    }
}