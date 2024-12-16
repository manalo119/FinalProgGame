namespace FinalProgGame
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            viewMenu = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            moregameDropdown = new ToolStripMenuItem();
            puzzleDropdown = new ToolStripMenuItem();
            rockpaperscissorsDropdown = new ToolStripMenuItem();
            tictactoeDropdown = new ToolStripMenuItem();
            savethechickenDropdown = new ToolStripMenuItem();
            mainscreenDropdown = new ToolStripMenuItem();
            exitDropdown = new ToolStripMenuItem();
            txtScore = new Label();
            player = new PictureBox();
            ufo = new PictureBox();
            pillar1 = new PictureBox();
            pillar2 = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            viewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ufo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pillar2).BeginInit();
            SuspendLayout();
            // 
            // viewMenu
            // 
            viewMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            viewMenu.Location = new Point(0, 0);
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(918, 24);
            viewMenu.TabIndex = 7;
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
            moregameDropdown.DropDownItems.AddRange(new ToolStripItem[] { puzzleDropdown, rockpaperscissorsDropdown, tictactoeDropdown, savethechickenDropdown });
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
            // savethechickenDropdown
            // 
            savethechickenDropdown.Name = "savethechickenDropdown";
            savethechickenDropdown.Size = new Size(177, 22);
            savethechickenDropdown.Text = "Save the Chicken";
            savethechickenDropdown.Click += savethechickenDropdown_Click;
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
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.BackColor = Color.Transparent;
            txtScore.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.ForeColor = SystemColors.ActiveCaptionText;
            txtScore.Location = new Point(22, 44);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(52, 15);
            txtScore.TabIndex = 12;
            txtScore.Text = "Score: 0";
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.Halicopter;
            player.Location = new Point(74, 151);
            player.Name = "player";
            player.Size = new Size(100, 54);
            player.TabIndex = 11;
            player.TabStop = false;
            // 
            // ufo
            // 
            ufo.BackColor = Color.Transparent;
            ufo.BackgroundImageLayout = ImageLayout.None;
            ufo.Image = Properties.Resources.alien1;
            ufo.Location = new Point(815, 354);
            ufo.Name = "ufo";
            ufo.Size = new Size(68, 72);
            ufo.SizeMode = PictureBoxSizeMode.StretchImage;
            ufo.TabIndex = 10;
            ufo.TabStop = false;
            // 
            // pillar1
            // 
            pillar1.BackColor = Color.Transparent;
            pillar1.BackgroundImageLayout = ImageLayout.None;
            pillar1.Image = Properties.Resources.pillar;
            pillar1.Location = new Point(678, 26);
            pillar1.Name = "pillar1";
            pillar1.Size = new Size(61, 174);
            pillar1.SizeMode = PictureBoxSizeMode.StretchImage;
            pillar1.TabIndex = 9;
            pillar1.TabStop = false;
            pillar1.Tag = "pillar";
            // 
            // pillar2
            // 
            pillar2.Image = Properties.Resources.pillar;
            pillar2.Location = new Point(295, 298);
            pillar2.Name = "pillar2";
            pillar2.Size = new Size(61, 201);
            pillar2.SizeMode = PictureBoxSizeMode.StretchImage;
            pillar2.TabIndex = 8;
            pillar2.TabStop = false;
            pillar2.Tag = "pillar";
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += MainTimerEvent;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            BackgroundImage = Properties.Resources.Helebg;
            ClientSize = new Size(918, 499);
            Controls.Add(txtScore);
            Controls.Add(player);
            Controls.Add(ufo);
            Controls.Add(pillar1);
            Controls.Add(pillar2);
            Controls.Add(viewMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            Text = "Hele vs UFO";
            KeyDown += KeyisDown;
            KeyUp += KeyisUp;
            viewMenu.ResumeLayout(false);
            viewMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)ufo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pillar2).EndInit();
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
        private Label txtScore;
        private PictureBox player;
        private PictureBox ufo;
        private PictureBox pillar1;
        private PictureBox pillar2;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer timer1;
    }
}