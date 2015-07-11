namespace Word_Game
{
    partial class Fill_in_the_Blanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fill_in_the_Blanks));
            this.TimerLable = new System.Windows.Forms.Label();
            this.ScoreLable = new System.Windows.Forms.Label();
            this.NewWordLable = new System.Windows.Forms.Label();
            this.EnterWord = new System.Windows.Forms.Button();
            this.BackButon = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.Box1 = new System.Windows.Forms.ComboBox();
            this.Box2 = new System.Windows.Forms.ComboBox();
            this.Box3 = new System.Windows.Forms.ComboBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.flashTimer = new System.Windows.Forms.Timer(this.components);
            this.WelcomeLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerLable
            // 
            this.TimerLable.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLable.Location = new System.Drawing.Point(177, 43);
            this.TimerLable.Name = "TimerLable";
            this.TimerLable.Size = new System.Drawing.Size(125, 23);
            this.TimerLable.TabIndex = 6;
            this.TimerLable.Text = "Time Remaining: 99";
            this.TimerLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ScoreLable
            // 
            this.ScoreLable.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLable.Location = new System.Drawing.Point(9, 43);
            this.ScoreLable.Name = "ScoreLable";
            this.ScoreLable.Size = new System.Drawing.Size(75, 23);
            this.ScoreLable.TabIndex = 5;
            this.ScoreLable.Text = "Tries: 99";
            // 
            // NewWordLable
            // 
            this.NewWordLable.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWordLable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewWordLable.Location = new System.Drawing.Point(2, 66);
            this.NewWordLable.Name = "NewWordLable";
            this.NewWordLable.Size = new System.Drawing.Size(312, 42);
            this.NewWordLable.TabIndex = 7;
            this.NewWordLable.Text = "THISISALONGWORD";
            this.NewWordLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterWord
            // 
            this.EnterWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterWord.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterWord.Location = new System.Drawing.Point(12, 151);
            this.EnterWord.Name = "EnterWord";
            this.EnterWord.Size = new System.Drawing.Size(227, 53);
            this.EnterWord.TabIndex = 8;
            this.EnterWord.Text = "Enter Text";
            this.EnterWord.UseVisualStyleBackColor = true;
            this.EnterWord.Click += new System.EventHandler(this.EnterWord_Click);
            // 
            // BackButon
            // 
            this.BackButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButon.Location = new System.Drawing.Point(245, 181);
            this.BackButon.Name = "BackButon";
            this.BackButon.Size = new System.Drawing.Size(57, 23);
            this.BackButon.TabIndex = 10;
            this.BackButon.Text = "Back";
            this.BackButon.UseVisualStyleBackColor = true;
            this.BackButon.Click += new System.EventHandler(this.BackButon_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Location = new System.Drawing.Point(245, 151);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(57, 23);
            this.RestartButton.TabIndex = 9;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Box1
            // 
            this.Box1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.FormattingEnabled = true;
            this.Box1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.Box1.Location = new System.Drawing.Point(49, 111);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(60, 34);
            this.Box1.TabIndex = 11;
            this.Box1.Visible = false;
            // 
            // Box2
            // 
            this.Box2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box2.FormattingEnabled = true;
            this.Box2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.Box2.Location = new System.Drawing.Point(127, 111);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(60, 34);
            this.Box2.TabIndex = 12;
            this.Box2.Visible = false;
            // 
            // Box3
            // 
            this.Box3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Box3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box3.FormattingEnabled = true;
            this.Box3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.Box3.Location = new System.Drawing.Point(203, 111);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(60, 34);
            this.Box3.TabIndex = 13;
            this.Box3.Visible = false;
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
            // WelcomeLable
            // 
            this.WelcomeLable.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLable.Location = new System.Drawing.Point(12, 8);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(290, 35);
            this.WelcomeLable.TabIndex = 14;
            this.WelcomeLable.Text = ".................... is playing,\r\n .................... on .......... mode";
            this.WelcomeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fill_in_the_Blanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(314, 215);
            this.Controls.Add(this.WelcomeLable);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.BackButon);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.EnterWord);
            this.Controls.Add(this.NewWordLable);
            this.Controls.Add(this.TimerLable);
            this.Controls.Add(this.ScoreLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(19, 9);
            this.MaximizeBox = false;
            this.Name = "Fill_in_the_Blanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jacob\'s Word Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TimerLable;
        private System.Windows.Forms.Label ScoreLable;
        private System.Windows.Forms.Label NewWordLable;
        private System.Windows.Forms.Button EnterWord;
        private System.Windows.Forms.Button BackButon;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.ComboBox Box1;
        private System.Windows.Forms.ComboBox Box2;
        private System.Windows.Forms.ComboBox Box3;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer flashTimer;
        private System.Windows.Forms.Label WelcomeLable;
    }
}