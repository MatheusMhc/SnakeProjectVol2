namespace SnakeGameSpace
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            lblExit = new Label();
            lblAbout = new Label();
            lblNewGame = new Label();
            lblEasy = new Label();
            lblMedium = new Label();
            lblHard = new Label();
            loadingProgress = new ProgressBar();
            lblBack = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 60F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(19, 75);
            label1.Name = "label1";
            label1.Size = new Size(629, 98);
            label1.TabIndex = 1;
            label1.Text = "Resident Cobra 2 ";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Transparent;
            lblExit.Font = new Font("Bodoni MT", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblExit.ForeColor = Color.White;
            lblExit.Location = new Point(260, 321);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(84, 41);
            lblExit.TabIndex = 4;
            lblExit.Text = "Exit";
            lblExit.Click += lblExit_Click;
            lblExit.MouseLeave += lblExit_MouseLeave;
            lblExit.MouseMove += lblExit_MouseMove;
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.BackColor = Color.Transparent;
            lblAbout.Font = new Font("Bodoni MT", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAbout.ForeColor = Color.White;
            lblAbout.Location = new Point(245, 262);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(111, 41);
            lblAbout.TabIndex = 5;
            lblAbout.Text = "About";
            lblAbout.Click += lblAbout_Click;
            lblAbout.MouseLeave += lblAbout_MouseLeave;
            lblAbout.MouseMove += lblAbout_MouseMove;
            // 
            // lblNewGame
            // 
            lblNewGame.AutoSize = true;
            lblNewGame.BackColor = Color.Transparent;
            lblNewGame.Font = new Font("Bodoni MT", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewGame.ForeColor = Color.White;
            lblNewGame.Location = new Point(209, 207);
            lblNewGame.Name = "lblNewGame";
            lblNewGame.Size = new Size(179, 41);
            lblNewGame.TabIndex = 6;
            lblNewGame.Text = "New Game";
            lblNewGame.MouseClick += lblNewGame_MouseClick;
            lblNewGame.MouseLeave += lblNewGame_MouseLeave;
            lblNewGame.MouseMove += lblNewGame_MouseMove;
            // 
            // lblEasy
            // 
            lblEasy.AutoSize = true;
            lblEasy.BackColor = Color.Transparent;
            lblEasy.Font = new Font("Bodoni MT", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEasy.ForeColor = Color.White;
            lblEasy.Location = new Point(256, 198);
            lblEasy.Name = "lblEasy";
            lblEasy.Size = new Size(91, 41);
            lblEasy.TabIndex = 7;
            lblEasy.Text = "Easy";
            lblEasy.Click += lblEasy_Click;
            lblEasy.MouseLeave += lblEasy_MouseLeave;
            lblEasy.MouseMove += lblEasy_MouseMove;
            // 
            // lblMedium
            // 
            lblMedium.AutoSize = true;
            lblMedium.BackColor = Color.Transparent;
            lblMedium.Font = new Font("Bodoni MT", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedium.ForeColor = Color.White;
            lblMedium.Location = new Point(232, 281);
            lblMedium.Name = "lblMedium";
            lblMedium.Size = new Size(139, 41);
            lblMedium.TabIndex = 8;
            lblMedium.Text = "Medium";
            lblMedium.Click += lblMedium_Click;
            lblMedium.MouseLeave += lblMedium_MouseLeave;
            lblMedium.MouseMove += lblMedium_MouseMove;
            // 
            // lblHard
            // 
            lblHard.AutoSize = true;
            lblHard.BackColor = Color.Transparent;
            lblHard.Font = new Font("Bodoni MT", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHard.ForeColor = Color.White;
            lblHard.Location = new Point(260, 366);
            lblHard.Name = "lblHard";
            lblHard.Size = new Size(95, 41);
            lblHard.TabIndex = 9;
            lblHard.Text = "Hard";
            lblHard.Click += lblHard_Click;
            lblHard.MouseLeave += lblHard_MouseLeave;
            lblHard.MouseMove += lblHard_MouseMove;
            // 
            // loadingProgress
            // 
            loadingProgress.ForeColor = Color.Green;
            loadingProgress.Location = new Point(134, 420);
            loadingProgress.Maximum = 400;
            loadingProgress.Name = "loadingProgress";
            loadingProgress.Size = new Size(365, 23);
            loadingProgress.TabIndex = 10;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.BackColor = Color.Transparent;
            lblBack.Font = new Font("Snap ITC", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lblBack.Location = new Point(655, 393);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(112, 45);
            lblBack.TabIndex = 11;
            lblBack.Text = "Back";
            lblBack.Click += lblBack_Click;
            lblBack.MouseLeave += lblBack_MouseLeave;
            lblBack.MouseMove += lblBack_MouseMove;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(635, 513);
            Controls.Add(loadingProgress);
            Controls.Add(lblBack);
            Controls.Add(lblHard);
            Controls.Add(lblMedium);
            Controls.Add(lblEasy);
            Controls.Add(lblNewGame);
            Controls.Add(lblAbout);
            Controls.Add(lblExit);
            Controls.Add(label1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Snake Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblExit;
        private Label lblAbout;
        private Label lblNewGame;
        private Label lblEasy;
        private Label lblMedium;
        private Label lblHard;
        public ProgressBar loadingProgress;
        private Label lblBack;
    }
}