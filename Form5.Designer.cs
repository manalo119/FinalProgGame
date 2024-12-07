namespace FinalProgGame
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            viewMenu = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            moregameDropdown = new ToolStripMenuItem();
            puzzleDropdown = new ToolStripMenuItem();
            rockpaperscissorsDropdown = new ToolStripMenuItem();
            tictactoeDropdown = new ToolStripMenuItem();
            flyingufoDropdown = new ToolStripMenuItem();
            mainscreenDropdown = new ToolStripMenuItem();
            exitDropdown = new ToolStripMenuItem();
            chicken = new PictureBox();
            pictureBox5 = new PictureBox();
            txtScore = new Label();
            pictureBox4 = new PictureBox();
            txtHealth = new Label();
            pictureBox6 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            viewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // viewMenu
            // 
            viewMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            viewMenu.Location = new Point(0, 0);
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(650, 24);
            viewMenu.TabIndex = 6;
            viewMenu.Text = "Game";
            viewMenu.Visible = false;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(12, 20);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { moregameDropdown, mainscreenDropdown, exitDropdown });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(44, 20);
            toolStripMenuItem3.Text = "View";
            // 
            // moregameDropdown
            // 
            moregameDropdown.DropDownItems.AddRange(new ToolStripItem[] { puzzleDropdown, rockpaperscissorsDropdown, tictactoeDropdown, flyingufoDropdown });
            moregameDropdown.Name = "moregameDropdown";
            moregameDropdown.Size = new Size(139, 22);
            moregameDropdown.Text = "More Game";
            // 
            // puzzleDropdown
            // 
            puzzleDropdown.Name = "puzzleDropdown";
            puzzleDropdown.Size = new Size(177, 22);
            puzzleDropdown.Text = "Puzzle";
            puzzleDropdown.Click += puzzleDropdown_Click;
            // 
            // rockpaperscissorsDropdown
            // 
            rockpaperscissorsDropdown.Name = "rockpaperscissorsDropdown";
            rockpaperscissorsDropdown.Size = new Size(177, 22);
            rockpaperscissorsDropdown.Text = "Rock Paper Scissors";
            rockpaperscissorsDropdown.Click += rockpaperscissorsDropdown_Click;
            // 
            // tictactoeDropdown
            // 
            tictactoeDropdown.Name = "tictactoeDropdown";
            tictactoeDropdown.Size = new Size(177, 22);
            tictactoeDropdown.Text = "Tic Tac Toe";
            tictactoeDropdown.Click += tictactoeDropdown_Click;
            // 
            // flyingufoDropdown
            // 
            flyingufoDropdown.Name = "flyingufoDropdown";
            flyingufoDropdown.Size = new Size(177, 22);
            flyingufoDropdown.Text = "Flying UFO";
            flyingufoDropdown.Click += flyingufoDropdown_Click;
            // 
            // mainscreenDropdown
            // 
            mainscreenDropdown.Name = "mainscreenDropdown";
            mainscreenDropdown.Size = new Size(139, 22);
            mainscreenDropdown.Text = "Main Screen";
            mainscreenDropdown.Click += mainscreenDropdown_Click;
            // 
            // exitDropdown
            // 
            exitDropdown.Name = "exitDropdown";
            exitDropdown.Size = new Size(139, 22);
            exitDropdown.Text = "Exit";
            exitDropdown.Click += exitDropdown_Click;
            // 
            // chicken
            // 
            chicken.Image = Properties.Resources.chicken_normal2;
            chicken.Location = new Point(542, 435);
            chicken.Name = "chicken";
            chicken.Size = new Size(76, 72);
            chicken.SizeMode = PictureBoxSizeMode.StretchImage;
            chicken.TabIndex = 18;
            chicken.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.egg;
            pictureBox5.Location = new Point(106, 31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(49, 58);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "eggs";
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.BackColor = Color.Transparent;
            txtScore.BorderStyle = BorderStyle.Fixed3D;
            txtScore.Location = new Point(477, 5);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(83, 17);
            txtScore.TabIndex = 16;
            txtScore.Text = "Egg Caught: 0";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.egg;
            pictureBox4.Location = new Point(294, 53);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 58);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "eggs";
            // 
            // txtHealth
            // 
            txtHealth.AutoSize = true;
            txtHealth.BackColor = Color.Transparent;
            txtHealth.BorderStyle = BorderStyle.Fixed3D;
            txtHealth.Location = new Point(567, 5);
            txtHealth.Name = "txtHealth";
            txtHealth.Size = new Size(56, 17);
            txtHealth.TabIndex = 17;
            txtHealth.Text = "Health: 0";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.egg;
            pictureBox6.Location = new Point(475, 39);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(49, 58);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "eggs";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 50;
            gameTimer.Tick += gameTick;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(650, 512);
            Controls.Add(chicken);
            Controls.Add(pictureBox5);
            Controls.Add(txtScore);
            Controls.Add(pictureBox4);
            Controls.Add(txtHealth);
            Controls.Add(pictureBox6);
            Controls.Add(viewMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Save the Egg";
            KeyDown += KeyisDown;
            KeyUp += KeyisUp;
            viewMenu.ResumeLayout(false);
            viewMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip viewMenu;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem moregameDropdown;
        private ToolStripMenuItem puzzleDropdown;
        private ToolStripMenuItem tictactoeDropdown;
        private ToolStripMenuItem savethechickenDropdown;
        private ToolStripMenuItem flyingufoDropdown;
        private ToolStripMenuItem mainscreenDropdown;
        private ToolStripMenuItem exitDropdown;
        private ToolStripMenuItem rockpaperscissorsDropdown;
        private PictureBox chicken;
        private PictureBox pictureBox5;
        private Label txtScore;
        private PictureBox pictureBox4;
        private Label txtHealth;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer gameTimer;
    }
}