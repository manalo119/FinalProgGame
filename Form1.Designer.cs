namespace FinalProgGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnRockPaperScissors = new Button();
            btnTicTacToe = new Button();
            btnSaveTheEgg = new Button();
            btnFlyingUFO = new Button();
            btnPuzzle = new Button();
            SuspendLayout();
            // 
            // btnRockPaperScissors
            // 
            btnRockPaperScissors.BackColor = Color.Transparent;
            btnRockPaperScissors.BackgroundImage = Properties.Resources.RPS_logo;
            btnRockPaperScissors.BackgroundImageLayout = ImageLayout.Stretch;
            btnRockPaperScissors.Font = new Font("STHupo", 20.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            btnRockPaperScissors.ForeColor = Color.Navy;
            btnRockPaperScissors.Location = new Point(241, 98);
            btnRockPaperScissors.Name = "btnRockPaperScissors";
            btnRockPaperScissors.Size = new Size(161, 119);
            btnRockPaperScissors.TabIndex = 1;
            btnRockPaperScissors.Text = "Rock Paper Scissors";
            btnRockPaperScissors.UseVisualStyleBackColor = false;
            btnRockPaperScissors.Click += btnRockPaperScissors_Click;
            // 
            // btnTicTacToe
            // 
            btnTicTacToe.BackgroundImage = Properties.Resources.tic_tac_toe_logo;
            btnTicTacToe.BackgroundImageLayout = ImageLayout.Stretch;
            btnTicTacToe.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTicTacToe.ForeColor = Color.Purple;
            btnTicTacToe.Location = new Point(433, 98);
            btnTicTacToe.Name = "btnTicTacToe";
            btnTicTacToe.Size = new Size(161, 119);
            btnTicTacToe.TabIndex = 2;
            btnTicTacToe.Text = "Tic Tac Toe";
            btnTicTacToe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTicTacToe.UseVisualStyleBackColor = true;
            btnTicTacToe.Click += btnTicTacToe_Click;
            // 
            // btnSaveTheEgg
            // 
            btnSaveTheEgg.BackgroundImage = Properties.Resources.Save_the_Egg_logo;
            btnSaveTheEgg.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaveTheEgg.Font = new Font("Broadway", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSaveTheEgg.ForeColor = Color.FromArgb(64, 64, 0);
            btnSaveTheEgg.Location = new Point(39, 263);
            btnSaveTheEgg.Name = "btnSaveTheEgg";
            btnSaveTheEgg.Size = new Size(161, 119);
            btnSaveTheEgg.TabIndex = 3;
            btnSaveTheEgg.Text = "Save the Egg";
            btnSaveTheEgg.TextAlign = ContentAlignment.BottomCenter;
            btnSaveTheEgg.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSaveTheEgg.UseVisualStyleBackColor = true;
            btnSaveTheEgg.UseWaitCursor = true;
            btnSaveTheEgg.Click += btnSaveTheEgg_Click;
            // 
            // btnFlyingUFO
            // 
            btnFlyingUFO.BackgroundImage = Properties.Resources.Helicopter_flying;
            btnFlyingUFO.BackgroundImageLayout = ImageLayout.Stretch;
            btnFlyingUFO.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFlyingUFO.ForeColor = Color.FromArgb(0, 192, 192);
            btnFlyingUFO.Location = new Point(241, 262);
            btnFlyingUFO.Name = "btnFlyingUFO";
            btnFlyingUFO.Size = new Size(161, 119);
            btnFlyingUFO.TabIndex = 4;
            btnFlyingUFO.Text = "HELECOPTER VS UFO";
            btnFlyingUFO.TextAlign = ContentAlignment.BottomCenter;
            btnFlyingUFO.UseVisualStyleBackColor = true;
            btnFlyingUFO.Click += btnFlyingUFO_Click;
            // 
            // btnPuzzle
            // 
            btnPuzzle.BackColor = Color.White;
            btnPuzzle.BackgroundImage = Properties.Resources.puzzle_logo;
            btnPuzzle.BackgroundImageLayout = ImageLayout.Stretch;
            btnPuzzle.FlatAppearance.BorderColor = Color.Gray;
            btnPuzzle.FlatStyle = FlatStyle.Flat;
            btnPuzzle.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPuzzle.ForeColor = Color.White;
            btnPuzzle.Location = new Point(39, 100);
            btnPuzzle.Name = "btnPuzzle";
            btnPuzzle.Size = new Size(161, 119);
            btnPuzzle.TabIndex = 5;
            btnPuzzle.Text = "PUZZLE";
            btnPuzzle.UseVisualStyleBackColor = false;
            btnPuzzle.Click += btnPuzzle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 499);
            Controls.Add(btnPuzzle);
            Controls.Add(btnFlyingUFO);
            Controls.Add(btnSaveTheEgg);
            Controls.Add(btnTicTacToe);
            Controls.Add(btnRockPaperScissors);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CSThrowbackGames";
            ResumeLayout(false);
        }

        #endregion
        private Button btnRockPaperScissors;
        private Button btnTicTacToe;
        private Button btnSaveTheEgg;
        private Button btnFlyingUFO;
        private Button btnPuzzle;
    }
}
