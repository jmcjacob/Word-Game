namespace Word_Game
{
    partial class Guess_The_Word
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guess_The_Word));
            this.NewWordLable = new System.Windows.Forms.Label();
            this.TimerLable = new System.Windows.Forms.Label();
            this.ScoreLable = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.flashTimer = new System.Windows.Forms.Timer(this.components);
            this.AButton = new System.Windows.Forms.Button();
            this.BButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.DButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.FButton = new System.Windows.Forms.Button();
            this.GButton = new System.Windows.Forms.Button();
            this.HButton = new System.Windows.Forms.Button();
            this.IButton = new System.Windows.Forms.Button();
            this.JButton = new System.Windows.Forms.Button();
            this.KButton = new System.Windows.Forms.Button();
            this.LButton = new System.Windows.Forms.Button();
            this.MButton = new System.Windows.Forms.Button();
            this.NButton = new System.Windows.Forms.Button();
            this.OButton = new System.Windows.Forms.Button();
            this.PButton = new System.Windows.Forms.Button();
            this.QButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.SButton = new System.Windows.Forms.Button();
            this.TButton = new System.Windows.Forms.Button();
            this.UButton = new System.Windows.Forms.Button();
            this.VButton = new System.Windows.Forms.Button();
            this.WButton = new System.Windows.Forms.Button();
            this.XButton = new System.Windows.Forms.Button();
            this.YButton = new System.Windows.Forms.Button();
            this.ZButton = new System.Windows.Forms.Button();
            this.BackButon = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.WelcomeLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewWordLable
            // 
            this.NewWordLable.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWordLable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewWordLable.Location = new System.Drawing.Point(11, 67);
            this.NewWordLable.Name = "NewWordLable";
            this.NewWordLable.Size = new System.Drawing.Size(312, 42);
            this.NewWordLable.TabIndex = 14;
            this.NewWordLable.Text = "THISISALONGWORD";
            this.NewWordLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerLable
            // 
            this.TimerLable.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLable.Location = new System.Drawing.Point(186, 44);
            this.TimerLable.Name = "TimerLable";
            this.TimerLable.Size = new System.Drawing.Size(125, 23);
            this.TimerLable.TabIndex = 13;
            this.TimerLable.Text = "Time Remaining: 99";
            this.TimerLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ScoreLable
            // 
            this.ScoreLable.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLable.Location = new System.Drawing.Point(15, 44);
            this.ScoreLable.Name = "ScoreLable";
            this.ScoreLable.Size = new System.Drawing.Size(75, 23);
            this.ScoreLable.TabIndex = 12;
            this.ScoreLable.Text = "Tries: 99";
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
            // AButton
            // 
            this.AButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AButton.Location = new System.Drawing.Point(21, 112);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(31, 28);
            this.AButton.TabIndex = 16;
            this.AButton.Text = "A";
            this.AButton.UseVisualStyleBackColor = true;
            this.AButton.Click += new System.EventHandler(this.button);
            // 
            // BButton
            // 
            this.BButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BButton.Location = new System.Drawing.Point(58, 112);
            this.BButton.Name = "BButton";
            this.BButton.Size = new System.Drawing.Size(31, 28);
            this.BButton.TabIndex = 17;
            this.BButton.Text = "B";
            this.BButton.UseVisualStyleBackColor = true;
            this.BButton.Click += new System.EventHandler(this.button);
            // 
            // CButton
            // 
            this.CButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CButton.Location = new System.Drawing.Point(95, 112);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(31, 28);
            this.CButton.TabIndex = 18;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.button);
            // 
            // DButton
            // 
            this.DButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DButton.Location = new System.Drawing.Point(132, 112);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(31, 28);
            this.DButton.TabIndex = 19;
            this.DButton.Text = "D";
            this.DButton.UseVisualStyleBackColor = true;
            this.DButton.Click += new System.EventHandler(this.button);
            // 
            // EButton
            // 
            this.EButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EButton.Location = new System.Drawing.Point(169, 112);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(31, 28);
            this.EButton.TabIndex = 20;
            this.EButton.Text = "E";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.button);
            // 
            // FButton
            // 
            this.FButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FButton.Location = new System.Drawing.Point(206, 112);
            this.FButton.Name = "FButton";
            this.FButton.Size = new System.Drawing.Size(31, 28);
            this.FButton.TabIndex = 21;
            this.FButton.Text = "F";
            this.FButton.UseVisualStyleBackColor = true;
            this.FButton.Click += new System.EventHandler(this.button);
            // 
            // GButton
            // 
            this.GButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GButton.Location = new System.Drawing.Point(243, 112);
            this.GButton.Name = "GButton";
            this.GButton.Size = new System.Drawing.Size(31, 28);
            this.GButton.TabIndex = 22;
            this.GButton.Text = "G";
            this.GButton.UseVisualStyleBackColor = true;
            this.GButton.Click += new System.EventHandler(this.button);
            // 
            // HButton
            // 
            this.HButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HButton.Location = new System.Drawing.Point(280, 112);
            this.HButton.Name = "HButton";
            this.HButton.Size = new System.Drawing.Size(31, 28);
            this.HButton.TabIndex = 23;
            this.HButton.Text = "H";
            this.HButton.UseVisualStyleBackColor = true;
            this.HButton.Click += new System.EventHandler(this.button);
            // 
            // IButton
            // 
            this.IButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IButton.Location = new System.Drawing.Point(21, 146);
            this.IButton.Name = "IButton";
            this.IButton.Size = new System.Drawing.Size(31, 28);
            this.IButton.TabIndex = 24;
            this.IButton.Text = "I";
            this.IButton.UseVisualStyleBackColor = true;
            this.IButton.Click += new System.EventHandler(this.button);
            // 
            // JButton
            // 
            this.JButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JButton.Location = new System.Drawing.Point(58, 146);
            this.JButton.Name = "JButton";
            this.JButton.Size = new System.Drawing.Size(31, 28);
            this.JButton.TabIndex = 25;
            this.JButton.Text = "J";
            this.JButton.UseVisualStyleBackColor = true;
            this.JButton.Click += new System.EventHandler(this.button);
            // 
            // KButton
            // 
            this.KButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KButton.Location = new System.Drawing.Point(95, 146);
            this.KButton.Name = "KButton";
            this.KButton.Size = new System.Drawing.Size(31, 28);
            this.KButton.TabIndex = 26;
            this.KButton.Text = "K";
            this.KButton.UseVisualStyleBackColor = true;
            this.KButton.Click += new System.EventHandler(this.button);
            // 
            // LButton
            // 
            this.LButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LButton.Location = new System.Drawing.Point(132, 146);
            this.LButton.Name = "LButton";
            this.LButton.Size = new System.Drawing.Size(31, 28);
            this.LButton.TabIndex = 27;
            this.LButton.Text = "L";
            this.LButton.UseVisualStyleBackColor = true;
            this.LButton.Click += new System.EventHandler(this.button);
            // 
            // MButton
            // 
            this.MButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MButton.Location = new System.Drawing.Point(169, 146);
            this.MButton.Name = "MButton";
            this.MButton.Size = new System.Drawing.Size(31, 28);
            this.MButton.TabIndex = 28;
            this.MButton.Text = "M";
            this.MButton.UseVisualStyleBackColor = true;
            this.MButton.Click += new System.EventHandler(this.button);
            // 
            // NButton
            // 
            this.NButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NButton.Location = new System.Drawing.Point(206, 146);
            this.NButton.Name = "NButton";
            this.NButton.Size = new System.Drawing.Size(31, 28);
            this.NButton.TabIndex = 29;
            this.NButton.Text = "N";
            this.NButton.UseVisualStyleBackColor = true;
            this.NButton.Click += new System.EventHandler(this.button);
            // 
            // OButton
            // 
            this.OButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OButton.Location = new System.Drawing.Point(243, 146);
            this.OButton.Name = "OButton";
            this.OButton.Size = new System.Drawing.Size(31, 28);
            this.OButton.TabIndex = 30;
            this.OButton.Text = "O";
            this.OButton.UseVisualStyleBackColor = true;
            this.OButton.Click += new System.EventHandler(this.button);
            // 
            // PButton
            // 
            this.PButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PButton.Location = new System.Drawing.Point(280, 146);
            this.PButton.Name = "PButton";
            this.PButton.Size = new System.Drawing.Size(31, 28);
            this.PButton.TabIndex = 31;
            this.PButton.Text = "P";
            this.PButton.UseVisualStyleBackColor = true;
            this.PButton.Click += new System.EventHandler(this.button);
            // 
            // QButton
            // 
            this.QButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QButton.Location = new System.Drawing.Point(21, 180);
            this.QButton.Name = "QButton";
            this.QButton.Size = new System.Drawing.Size(31, 28);
            this.QButton.TabIndex = 32;
            this.QButton.Text = "Q";
            this.QButton.UseVisualStyleBackColor = true;
            this.QButton.Click += new System.EventHandler(this.button);
            // 
            // RButton
            // 
            this.RButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RButton.Location = new System.Drawing.Point(58, 180);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(31, 28);
            this.RButton.TabIndex = 33;
            this.RButton.Text = "R";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.button);
            // 
            // SButton
            // 
            this.SButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SButton.Location = new System.Drawing.Point(95, 180);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(31, 28);
            this.SButton.TabIndex = 34;
            this.SButton.Text = "S";
            this.SButton.UseVisualStyleBackColor = true;
            this.SButton.Click += new System.EventHandler(this.button);
            // 
            // TButton
            // 
            this.TButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TButton.Location = new System.Drawing.Point(132, 180);
            this.TButton.Name = "TButton";
            this.TButton.Size = new System.Drawing.Size(31, 28);
            this.TButton.TabIndex = 35;
            this.TButton.Text = "T";
            this.TButton.UseVisualStyleBackColor = true;
            this.TButton.Click += new System.EventHandler(this.button);
            // 
            // UButton
            // 
            this.UButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UButton.Location = new System.Drawing.Point(169, 180);
            this.UButton.Name = "UButton";
            this.UButton.Size = new System.Drawing.Size(31, 28);
            this.UButton.TabIndex = 36;
            this.UButton.Text = "U";
            this.UButton.UseVisualStyleBackColor = true;
            this.UButton.Click += new System.EventHandler(this.button);
            // 
            // VButton
            // 
            this.VButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VButton.Location = new System.Drawing.Point(206, 180);
            this.VButton.Name = "VButton";
            this.VButton.Size = new System.Drawing.Size(31, 28);
            this.VButton.TabIndex = 37;
            this.VButton.Text = "V";
            this.VButton.UseVisualStyleBackColor = true;
            this.VButton.Click += new System.EventHandler(this.button);
            // 
            // WButton
            // 
            this.WButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WButton.Location = new System.Drawing.Point(243, 180);
            this.WButton.Name = "WButton";
            this.WButton.Size = new System.Drawing.Size(31, 28);
            this.WButton.TabIndex = 38;
            this.WButton.Text = "W";
            this.WButton.UseVisualStyleBackColor = true;
            this.WButton.Click += new System.EventHandler(this.button);
            // 
            // XButton
            // 
            this.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XButton.Location = new System.Drawing.Point(280, 180);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(31, 28);
            this.XButton.TabIndex = 39;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = true;
            this.XButton.Click += new System.EventHandler(this.button);
            // 
            // YButton
            // 
            this.YButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YButton.Location = new System.Drawing.Point(21, 214);
            this.YButton.Name = "YButton";
            this.YButton.Size = new System.Drawing.Size(31, 28);
            this.YButton.TabIndex = 40;
            this.YButton.Text = "Y";
            this.YButton.UseVisualStyleBackColor = true;
            this.YButton.Click += new System.EventHandler(this.button);
            // 
            // ZButton
            // 
            this.ZButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZButton.Location = new System.Drawing.Point(58, 214);
            this.ZButton.Name = "ZButton";
            this.ZButton.Size = new System.Drawing.Size(31, 28);
            this.ZButton.TabIndex = 41;
            this.ZButton.Text = "Z";
            this.ZButton.UseVisualStyleBackColor = true;
            this.ZButton.Click += new System.EventHandler(this.button);
            // 
            // BackButon
            // 
            this.BackButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButon.Location = new System.Drawing.Point(243, 214);
            this.BackButon.Name = "BackButon";
            this.BackButon.Size = new System.Drawing.Size(68, 27);
            this.BackButon.TabIndex = 43;
            this.BackButon.Text = "Back";
            this.BackButon.UseVisualStyleBackColor = true;
            this.BackButon.Click += new System.EventHandler(this.BackButon_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Location = new System.Drawing.Point(169, 214);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(68, 28);
            this.RestartButton.TabIndex = 42;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // WelcomeLable
            // 
            this.WelcomeLable.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLable.Location = new System.Drawing.Point(21, 9);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(290, 35);
            this.WelcomeLable.TabIndex = 44;
            this.WelcomeLable.Text = ".................... is playing,\r\n .................... on .......... mode";
            this.WelcomeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Guess_The_Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(333, 260);
            this.Controls.Add(this.WelcomeLable);
            this.Controls.Add(this.BackButon);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ZButton);
            this.Controls.Add(this.YButton);
            this.Controls.Add(this.XButton);
            this.Controls.Add(this.WButton);
            this.Controls.Add(this.VButton);
            this.Controls.Add(this.UButton);
            this.Controls.Add(this.TButton);
            this.Controls.Add(this.SButton);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.QButton);
            this.Controls.Add(this.PButton);
            this.Controls.Add(this.OButton);
            this.Controls.Add(this.NButton);
            this.Controls.Add(this.MButton);
            this.Controls.Add(this.LButton);
            this.Controls.Add(this.KButton);
            this.Controls.Add(this.JButton);
            this.Controls.Add(this.IButton);
            this.Controls.Add(this.HButton);
            this.Controls.Add(this.GButton);
            this.Controls.Add(this.FButton);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.DButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.BButton);
            this.Controls.Add(this.AButton);
            this.Controls.Add(this.NewWordLable);
            this.Controls.Add(this.TimerLable);
            this.Controls.Add(this.ScoreLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Guess_The_Word";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jacob\'s Word Game";
            this.Click += new System.EventHandler(this.button);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NewWordLable;
        private System.Windows.Forms.Label TimerLable;
        private System.Windows.Forms.Label ScoreLable;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer flashTimer;
        private System.Windows.Forms.Button AButton;
        private System.Windows.Forms.Button BButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button DButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Button FButton;
        private System.Windows.Forms.Button GButton;
        private System.Windows.Forms.Button HButton;
        private System.Windows.Forms.Button IButton;
        private System.Windows.Forms.Button JButton;
        private System.Windows.Forms.Button KButton;
        private System.Windows.Forms.Button LButton;
        private System.Windows.Forms.Button MButton;
        private System.Windows.Forms.Button NButton;
        private System.Windows.Forms.Button OButton;
        private System.Windows.Forms.Button PButton;
        private System.Windows.Forms.Button QButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button SButton;
        private System.Windows.Forms.Button TButton;
        private System.Windows.Forms.Button UButton;
        private System.Windows.Forms.Button VButton;
        private System.Windows.Forms.Button WButton;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button YButton;
        private System.Windows.Forms.Button ZButton;
        private System.Windows.Forms.Button BackButon;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label WelcomeLable;
    }
}