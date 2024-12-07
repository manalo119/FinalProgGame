namespace FinalProgGame
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            viewMenu = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            moregameDropdown = new ToolStripMenuItem();
            puzzleDropdown = new ToolStripMenuItem();
            tictactoeDropdown = new ToolStripMenuItem();
            savethechickenDropdown = new ToolStripMenuItem();
            flyingufoDropdown = new ToolStripMenuItem();
            mainscreenDropdown = new ToolStripMenuItem();
            exitDropdown = new ToolStripMenuItem();
            txtTime = new Label();
            groupBox4 = new GroupBox();
            pictureBox3 = new PictureBox();
            btnHelp = new Button();
            btnReset = new Button();
            btnScissors = new Button();
            btnPaper = new Button();
            btnRock = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            roundsText = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            txtMessageComputer = new Label();
            picComputer = new PictureBox();
            groupBox2 = new GroupBox();
            txtMessagePlayer = new Label();
            picPlayer = new PictureBox();
            countDownTimer = new System.Windows.Forms.Timer(components);
            viewMenu.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picComputer).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            SuspendLayout();
            // 
            // viewMenu
            // 
            viewMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            viewMenu.Location = new Point(0, 0);
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(918, 24);
            viewMenu.TabIndex = 4;
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
            moregameDropdown.DropDownItems.AddRange(new ToolStripItem[] { puzzleDropdown, tictactoeDropdown, savethechickenDropdown, flyingufoDropdown });
            moregameDropdown.Name = "moregameDropdown";
            moregameDropdown.Size = new Size(139, 22);
            moregameDropdown.Text = "More Game";
            // 
            // puzzleDropdown
            // 
            puzzleDropdown.Name = "puzzleDropdown";
            puzzleDropdown.Size = new Size(164, 22);
            puzzleDropdown.Text = "Puzzle";
            puzzleDropdown.Click += puzzleDropdown_Click;
            // 
            // tictactoeDropdown
            // 
            tictactoeDropdown.Name = "tictactoeDropdown";
            tictactoeDropdown.Size = new Size(164, 22);
            tictactoeDropdown.Text = "Tic Tac Toe";
            tictactoeDropdown.Click += tictactoeDropdown_Click;
            // 
            // savethechickenDropdown
            // 
            savethechickenDropdown.Name = "savethechickenDropdown";
            savethechickenDropdown.Size = new Size(164, 22);
            savethechickenDropdown.Text = "Save the Chicken";
            savethechickenDropdown.Click += savethechickenDropdown_Click;
            // 
            // flyingufoDropdown
            // 
            flyingufoDropdown.Name = "flyingufoDropdown";
            flyingufoDropdown.Size = new Size(164, 22);
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
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.BorderStyle = BorderStyle.Fixed3D;
            txtTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTime.Location = new Point(746, 319);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(25, 27);
            txtTime.TabIndex = 18;
            txtTime.Text = "0";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox3);
            groupBox4.Location = new Point(633, 47);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(249, 263);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rock Paper Scissors";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.RPS;
            pictureBox3.Location = new Point(12, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(224, 223);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(764, 409);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(86, 42);
            btnHelp.TabIndex = 22;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(665, 409);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 42);
            btnReset.TabIndex = 21;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(813, 353);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(86, 42);
            btnScissors.TabIndex = 20;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(713, 353);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(86, 42);
            btnPaper.TabIndex = 19;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnRock
            // 
            btnRock.Location = new Point(616, 353);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(86, 42);
            btnRock.TabIndex = 17;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(roundsText);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(picComputer);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(picPlayer);
            groupBox1.Location = new Point(20, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 403);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game Interface";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 191);
            label1.Name = "label1";
            label1.Size = new Size(39, 30);
            label1.TabIndex = 8;
            label1.Text = "VS";
            // 
            // roundsText
            // 
            roundsText.AutoSize = true;
            roundsText.BorderStyle = BorderStyle.Fixed3D;
            roundsText.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundsText.Location = new Point(249, 111);
            roundsText.Name = "roundsText";
            roundsText.Size = new Size(74, 22);
            roundsText.TabIndex = 7;
            roundsText.Text = "Round: 5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(422, 111);
            label5.Name = "label5";
            label5.Size = new Size(81, 22);
            label5.TabIndex = 6;
            label5.Text = "Computer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 111);
            label4.Name = "label4";
            label4.Size = new Size(54, 22);
            label4.TabIndex = 5;
            label4.Text = "Player";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(txtMessageComputer);
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(413, 272);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(96, 53);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Computer";
            // 
            // txtMessageComputer
            // 
            txtMessageComputer.AutoSize = true;
            txtMessageComputer.BorderStyle = BorderStyle.Fixed3D;
            txtMessageComputer.Cursor = Cursors.No;
            txtMessageComputer.Font = new Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtMessageComputer.Location = new Point(38, 20);
            txtMessageComputer.Name = "txtMessageComputer";
            txtMessageComputer.Size = new Size(22, 21);
            txtMessageComputer.TabIndex = 1;
            txtMessageComputer.Text = "0";
            // 
            // picComputer
            // 
            picComputer.BorderStyle = BorderStyle.Fixed3D;
            picComputer.Image = Properties.Resources.qq;
            picComputer.Location = new Point(377, 139);
            picComputer.Name = "picComputer";
            picComputer.Size = new Size(166, 124);
            picComputer.SizeMode = PictureBoxSizeMode.StretchImage;
            picComputer.TabIndex = 3;
            picComputer.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMessagePlayer);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(61, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(96, 53);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Player";
            // 
            // txtMessagePlayer
            // 
            txtMessagePlayer.AutoSize = true;
            txtMessagePlayer.BorderStyle = BorderStyle.Fixed3D;
            txtMessagePlayer.Cursor = Cursors.No;
            txtMessagePlayer.Font = new Font("STHupo", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtMessagePlayer.Location = new Point(38, 20);
            txtMessagePlayer.Name = "txtMessagePlayer";
            txtMessagePlayer.Size = new Size(22, 21);
            txtMessagePlayer.TabIndex = 0;
            txtMessagePlayer.Text = "0";
            // 
            // picPlayer
            // 
            picPlayer.BorderStyle = BorderStyle.Fixed3D;
            picPlayer.Image = Properties.Resources.qq;
            picPlayer.Location = new Point(29, 139);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(166, 124);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 0;
            picPlayer.TabStop = false;
            // 
            // countDownTimer
            // 
            countDownTimer.Interval = 1000;
            countDownTimer.Tick += countDownTimer_Tick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 499);
            Controls.Add(txtTime);
            Controls.Add(groupBox4);
            Controls.Add(btnHelp);
            Controls.Add(btnReset);
            Controls.Add(btnScissors);
            Controls.Add(btnPaper);
            Controls.Add(btnRock);
            Controls.Add(groupBox1);
            Controls.Add(viewMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Rock Paper Scissors";
            viewMenu.ResumeLayout(false);
            viewMenu.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picComputer).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
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
        private Label txtTime;
        private GroupBox groupBox4;
        private PictureBox pictureBox3;
        private Button btnHelp;
        private Button btnReset;
        private Button btnScissors;
        private Button btnPaper;
        private Button btnRock;
        private GroupBox groupBox1;
        private Label label1;
        private Label roundsText;
        private Label label5;
        private Label label4;
        private GroupBox groupBox3;
        private Label txtMessageComputer;
        private PictureBox picComputer;
        private GroupBox groupBox2;
        private Label txtMessagePlayer;
        private PictureBox picPlayer;
        private System.Windows.Forms.Timer countDownTimer;
    }
}