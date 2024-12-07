namespace FinalProgGame
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            viewMenu = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            moregameDropdown = new ToolStripMenuItem();
            rockpaperscissorsDropdown = new ToolStripMenuItem();
            tictactoeDropdown = new ToolStripMenuItem();
            savethechickenDropdown = new ToolStripMenuItem();
            flyingufoDropdown = new ToolStripMenuItem();
            mainscreenDropdown = new ToolStripMenuItem();
            exitDropdown = new ToolStripMenuItem();
            lblMovesMade = new Label();
            btnQuit = new Button();
            btnPause = new Button();
            btnShuffle = new Button();
            lblTimeElapsed = new Label();
            groupBox2 = new GroupBox();
            gbPuzzleBox = new GroupBox();
            pbx9 = new PictureBox();
            pbx8 = new PictureBox();
            pbx7 = new PictureBox();
            pbx6 = new PictureBox();
            pbx5 = new PictureBox();
            pbx4 = new PictureBox();
            pbx3 = new PictureBox();
            pbx2 = new PictureBox();
            pbx1 = new PictureBox();
            tmrTimeElapse = new System.Windows.Forms.Timer(components);
            viewMenu.SuspendLayout();
            gbPuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx1).BeginInit();
            SuspendLayout();
            // 
            // viewMenu
            // 
            viewMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            viewMenu.Location = new Point(0, 0);
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(918, 24);
            viewMenu.TabIndex = 3;
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
            moregameDropdown.DropDownItems.AddRange(new ToolStripItem[] { rockpaperscissorsDropdown, tictactoeDropdown, savethechickenDropdown, flyingufoDropdown });
            moregameDropdown.Name = "moregameDropdown";
            moregameDropdown.Size = new Size(180, 22);
            moregameDropdown.Text = "More Game";
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
            mainscreenDropdown.Size = new Size(180, 22);
            mainscreenDropdown.Text = "Main Screen";
            mainscreenDropdown.Click += mainscreenDropdown_Click;
            // 
            // exitDropdown
            // 
            exitDropdown.Name = "exitDropdown";
            exitDropdown.Size = new Size(180, 22);
            exitDropdown.Text = "Exit";
            exitDropdown.Click += exitDropdown_Click;
            // 
            // lblMovesMade
            // 
            lblMovesMade.AutoSize = true;
            lblMovesMade.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovesMade.ForeColor = SystemColors.ControlDarkDark;
            lblMovesMade.Location = new Point(75, 469);
            lblMovesMade.Name = "lblMovesMade";
            lblMovesMade.Size = new Size(118, 19);
            lblMovesMade.TabIndex = 13;
            lblMovesMade.Text = "Moves Made : ";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(786, 426);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(86, 42);
            btnQuit.TabIndex = 12;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(664, 426);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(86, 42);
            btnPause.TabIndex = 11;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(545, 426);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(86, 42);
            btnShuffle.TabIndex = 10;
            btnShuffle.Text = "Shuffle";
            btnShuffle.UseVisualStyleBackColor = true;
            btnShuffle.Click += btnShuffle_Click;
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.AutoSize = true;
            lblTimeElapsed.BackColor = Color.Transparent;
            lblTimeElapsed.Font = new Font("Impact", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeElapsed.Location = new Point(577, 317);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(272, 80);
            lblTimeElapsed.TabIndex = 9;
            lblTimeElapsed.Text = "00:00:00";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.original;
            groupBox2.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox2.Location = new Point(548, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 282);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Original";
            // 
            // gbPuzzleBox
            // 
            gbPuzzleBox.Controls.Add(pbx9);
            gbPuzzleBox.Controls.Add(pbx8);
            gbPuzzleBox.Controls.Add(pbx7);
            gbPuzzleBox.Controls.Add(pbx6);
            gbPuzzleBox.Controls.Add(pbx5);
            gbPuzzleBox.Controls.Add(pbx4);
            gbPuzzleBox.Controls.Add(pbx3);
            gbPuzzleBox.Controls.Add(pbx2);
            gbPuzzleBox.Controls.Add(pbx1);
            gbPuzzleBox.Location = new Point(46, 26);
            gbPuzzleBox.Name = "gbPuzzleBox";
            gbPuzzleBox.Size = new Size(427, 433);
            gbPuzzleBox.TabIndex = 7;
            gbPuzzleBox.TabStop = false;
            gbPuzzleBox.Text = "Puzzle";
            // 
            // pbx9
            // 
            pbx9.Location = new Point(281, 287);
            pbx9.Name = "pbx9";
            pbx9.Size = new Size(130, 130);
            pbx9.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx9.TabIndex = 8;
            pbx9.TabStop = false;
            pbx9.Click += SwitchPictureBox;
            // 
            // pbx8
            // 
            pbx8.Location = new Point(149, 287);
            pbx8.Name = "pbx8";
            pbx8.Size = new Size(130, 130);
            pbx8.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx8.TabIndex = 7;
            pbx8.TabStop = false;
            pbx8.Click += SwitchPictureBox;
            // 
            // pbx7
            // 
            pbx7.Location = new Point(17, 287);
            pbx7.Name = "pbx7";
            pbx7.Size = new Size(130, 130);
            pbx7.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx7.TabIndex = 6;
            pbx7.TabStop = false;
            pbx7.Click += SwitchPictureBox;
            // 
            // pbx6
            // 
            pbx6.Location = new Point(281, 155);
            pbx6.Name = "pbx6";
            pbx6.Size = new Size(130, 130);
            pbx6.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx6.TabIndex = 5;
            pbx6.TabStop = false;
            pbx6.Click += SwitchPictureBox;
            // 
            // pbx5
            // 
            pbx5.Location = new Point(149, 155);
            pbx5.Name = "pbx5";
            pbx5.Size = new Size(130, 130);
            pbx5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx5.TabIndex = 4;
            pbx5.TabStop = false;
            pbx5.Click += SwitchPictureBox;
            // 
            // pbx4
            // 
            pbx4.Location = new Point(17, 155);
            pbx4.Name = "pbx4";
            pbx4.Size = new Size(130, 130);
            pbx4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx4.TabIndex = 3;
            pbx4.TabStop = false;
            pbx4.Click += SwitchPictureBox;
            // 
            // pbx3
            // 
            pbx3.Location = new Point(281, 23);
            pbx3.Name = "pbx3";
            pbx3.Size = new Size(130, 130);
            pbx3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx3.TabIndex = 2;
            pbx3.TabStop = false;
            pbx3.Click += SwitchPictureBox;
            // 
            // pbx2
            // 
            pbx2.Location = new Point(149, 23);
            pbx2.Name = "pbx2";
            pbx2.Size = new Size(130, 130);
            pbx2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx2.TabIndex = 1;
            pbx2.TabStop = false;
            pbx2.Click += SwitchPictureBox;
            // 
            // pbx1
            // 
            pbx1.BackgroundImageLayout = ImageLayout.Stretch;
            pbx1.Location = new Point(17, 23);
            pbx1.Name = "pbx1";
            pbx1.Size = new Size(130, 130);
            pbx1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx1.TabIndex = 0;
            pbx1.TabStop = false;
            pbx1.Click += SwitchPictureBox;
            // 
            // tmrTimeElapse
            // 
            tmrTimeElapse.Enabled = true;
            tmrTimeElapse.Interval = 900;
            tmrTimeElapse.Tick += UpdateTimeElapsed;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 499);
            Controls.Add(lblMovesMade);
            Controls.Add(btnQuit);
            Controls.Add(btnPause);
            Controls.Add(btnShuffle);
            Controls.Add(lblTimeElapsed);
            Controls.Add(groupBox2);
            Controls.Add(gbPuzzleBox);
            Controls.Add(viewMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Puzzle";
            FormClosing += AskPermissionBeforeQuite;
            Load += Form2_Load;
            viewMenu.ResumeLayout(false);
            viewMenu.PerformLayout();
            gbPuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip viewMenu;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem moregameDropdown;
        private ToolStripMenuItem mainscreenDropdown;
        private ToolStripMenuItem exitDropdown;
        private ToolStripMenuItem rockpaperscissorsDropdown;
        private ToolStripMenuItem tictactoeDropdown;
        private ToolStripMenuItem savethechickenDropdown;
        private ToolStripMenuItem flyingufoDropdown;
        private Label lblMovesMade;
        private Button btnQuit;
        private Button btnPause;
        private Button btnShuffle;
        private Label lblTimeElapsed;
        private GroupBox groupBox2;
        private GroupBox gbPuzzleBox;
        private PictureBox pbx9;
        private PictureBox pbx8;
        private PictureBox pbx7;
        private PictureBox pbx6;
        private PictureBox pbx5;
        private PictureBox pbx4;
        private PictureBox pbx3;
        private PictureBox pbx2;
        private PictureBox pbx1;
        private System.Windows.Forms.Timer tmrTimeElapse;
    }
}