using System.Windows.Forms;

namespace SnakeProjectVol2
{
    partial class SnakeProjectVol2Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeProjectVol2Form));
            tableGridGameSkane = new TableLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            grpBoxScore = new GroupBox();
            label1 = new Label();
            picBoxDirectionals = new PictureBox();
            lblScoreValue = new Label();
            lblScoreName = new Label();
            lblNo = new Label();
            lblYes = new Label();
            lblDoYouContinue = new Label();
            loadingProgress = new ProgressBar();
            picBoxYouDead = new PictureBox();
            grpBoxScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxDirectionals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxYouDead).BeginInit();
            SuspendLayout();
            // 
            // tableGridGameSkane
            // 
            tableGridGameSkane.BackColor = SystemColors.Control;
            tableGridGameSkane.BackgroundImageLayout = ImageLayout.Center;
            tableGridGameSkane.BorderStyle = BorderStyle.FixedSingle;
            tableGridGameSkane.ColumnCount = 40;
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.Location = new Point(23, 12);
            tableGridGameSkane.Margin = new Padding(0);
            tableGridGameSkane.Name = "tableGridGameSkane";
            tableGridGameSkane.RowCount = 40;
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableGridGameSkane.Size = new Size(400, 400);
            tableGridGameSkane.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // grpBoxScore
            // 
            grpBoxScore.BackColor = Color.Red;
            grpBoxScore.Controls.Add(label1);
            grpBoxScore.Controls.Add(picBoxDirectionals);
            grpBoxScore.Controls.Add(lblScoreValue);
            grpBoxScore.Controls.Add(lblScoreName);
            grpBoxScore.Font = new Font("Bodoni MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoxScore.Location = new Point(451, 12);
            grpBoxScore.Name = "grpBoxScore";
            grpBoxScore.Size = new Size(319, 218);
            grpBoxScore.TabIndex = 3;
            grpBoxScore.TabStop = false;
            grpBoxScore.Text = "Resident Cobra 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 153);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 3;
            label1.Text = "Use:";
            // 
            // picBoxDirectionals
            // 
            picBoxDirectionals.Image = (Image)resources.GetObject("picBoxDirectionals.Image");
            picBoxDirectionals.Location = new Point(102, 106);
            picBoxDirectionals.Name = "picBoxDirectionals";
            picBoxDirectionals.Size = new Size(180, 106);
            picBoxDirectionals.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxDirectionals.TabIndex = 2;
            picBoxDirectionals.TabStop = false;
            // 
            // lblScoreValue
            // 
            lblScoreValue.AutoSize = true;
            lblScoreValue.ForeColor = Color.White;
            lblScoreValue.Location = new Point(103, 48);
            lblScoreValue.Name = "lblScoreValue";
            lblScoreValue.Size = new Size(27, 32);
            lblScoreValue.TabIndex = 1;
            lblScoreValue.Text = "0";
            // 
            // lblScoreName
            // 
            lblScoreName.AutoSize = true;
            lblScoreName.Location = new Point(16, 48);
            lblScoreName.Name = "lblScoreName";
            lblScoreName.Size = new Size(81, 32);
            lblScoreName.TabIndex = 0;
            lblScoreName.Text = "Score:";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.BackColor = Color.Black;
            lblNo.Font = new Font("Bodoni MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNo.ForeColor = Color.White;
            lblNo.Location = new Point(676, 397);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(44, 32);
            lblNo.TabIndex = 9;
            lblNo.Text = "No";
            lblNo.Visible = false;
            lblNo.Click += lblNo_Click;
            // 
            // lblYes
            // 
            lblYes.AutoSize = true;
            lblYes.BackColor = Color.Black;
            lblYes.Font = new Font("Bodoni MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblYes.ForeColor = Color.White;
            lblYes.Location = new Point(465, 397);
            lblYes.Name = "lblYes";
            lblYes.Size = new Size(53, 32);
            lblYes.TabIndex = 8;
            lblYes.Text = "Yes";
            lblYes.Visible = false;
            lblYes.Click += lblYes_Click;
            // 
            // lblDoYouContinue
            // 
            lblDoYouContinue.AutoSize = true;
            lblDoYouContinue.BackColor = Color.Black;
            lblDoYouContinue.Font = new Font("Bodoni MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoYouContinue.ForeColor = Color.White;
            lblDoYouContinue.Location = new Point(447, 325);
            lblDoYouContinue.Name = "lblDoYouContinue";
            lblDoYouContinue.Size = new Size(336, 32);
            lblDoYouContinue.TabIndex = 7;
            lblDoYouContinue.Text = "Do You Want To Try Again?";
            lblDoYouContinue.Visible = false;
            // 
            // loadingProgress
            // 
            loadingProgress.Location = new Point(12, 192);
            loadingProgress.Name = "loadingProgress";
            loadingProgress.Size = new Size(771, 23);
            loadingProgress.TabIndex = 10;
            // 
            // picBoxYouDead
            // 
            picBoxYouDead.Image = Properties.Resources.you_are_dead_game_over;
            picBoxYouDead.Location = new Point(426, 12);
            picBoxYouDead.Name = "picBoxYouDead";
            picBoxYouDead.Size = new Size(357, 288);
            picBoxYouDead.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxYouDead.TabIndex = 12;
            picBoxYouDead.TabStop = false;
            // 
            // SnakeProjectVol2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(795, 441);
            Controls.Add(loadingProgress);
            Controls.Add(lblNo);
            Controls.Add(lblYes);
            Controls.Add(lblDoYouContinue);
            Controls.Add(grpBoxScore);
            Controls.Add(tableGridGameSkane);
            Controls.Add(picBoxYouDead);
            Name = "SnakeProjectVol2Form";
            Text = "Form1";
            Load += SnakeProjectVol2_Load;
            KeyDown += Form1_KeyDown;
            grpBoxScore.ResumeLayout(false);
            grpBoxScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxDirectionals).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxYouDead).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableGridGameSkane;
        private System.Windows.Forms.Timer timer1;
        private GroupBox grpBoxScore;
        private Label label1;
        private PictureBox picBoxDirectionals;
        private Label lblScoreValue;
        private Label lblScoreName;
        private Label lblNo;
        private Label lblYes;
        private Label lblDoYouContinue;
        private ProgressBar loadingProgress;
        private PictureBox picBoxYouDead;
    }
}