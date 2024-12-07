namespace FinalProgGame
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            viewMenu = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            moregameDropdown = new ToolStripMenuItem();
            puzzleDropdown = new ToolStripMenuItem();
            rockpaperscissorsDropdown = new ToolStripMenuItem();
            savethechickenDropdown = new ToolStripMenuItem();
            flyingufoDropdown = new ToolStripMenuItem();
            mainscreenDropdown = new ToolStripMenuItem();
            exitDropdown = new ToolStripMenuItem();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            button10 = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tmrTimeElapse = new System.Windows.Forms.Timer(components);
            viewMenu.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // viewMenu
            // 
            viewMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            viewMenu.Location = new Point(0, 0);
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(884, 24);
            viewMenu.TabIndex = 5;
            viewMenu.Text = "Game";
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
            moregameDropdown.DropDownItems.AddRange(new ToolStripItem[] { puzzleDropdown, rockpaperscissorsDropdown, savethechickenDropdown, flyingufoDropdown });
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 50);
            label3.Name = "label3";
            label3.Size = new Size(81, 32);
            label3.TabIndex = 16;
            label3.Text = "Active";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 120);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 18;
            label2.Text = "Player 2 - O";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(625, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 168);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Score:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(11, 100);
            label7.Name = "label7";
            label7.Size = new Size(132, 37);
            label7.TabIndex = 14;
            label7.Text = "Player2 -";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(11, 58);
            label6.Name = "label6";
            label6.Size = new Size(132, 37);
            label6.TabIndex = 12;
            label6.Text = "Player1 -";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(135, 100);
            label5.Name = "label5";
            label5.Size = new Size(33, 37);
            label5.TabIndex = 13;
            label5.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(136, 58);
            label4.Name = "label4";
            label4.Size = new Size(33, 37);
            label4.TabIndex = 12;
            label4.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 91);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 17;
            label1.Text = "Player 1 - X";
            // 
            // button10
            // 
            button10.Location = new Point(752, 320);
            button10.Name = "button10";
            button10.Size = new Size(86, 42);
            button10.TabIndex = 14;
            button10.Text = "Exit";
            button10.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(638, 320);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 42);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(196, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 397);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game Interface";
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(254, 268);
            button9.Name = "button9";
            button9.Size = new Size(118, 117);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(130, 268);
            button8.Name = "button8";
            button8.Size = new Size(118, 117);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(6, 268);
            button7.Name = "button7";
            button7.Size = new Size(118, 117);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(254, 145);
            button6.Name = "button6";
            button6.Size = new Size(118, 117);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(130, 145);
            button5.Name = "button5";
            button5.Size = new Size(118, 117);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(6, 145);
            button4.Name = "button4";
            button4.Size = new Size(118, 117);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(254, 22);
            button3.Name = "button3";
            button3.Size = new Size(118, 117);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(130, 22);
            button2.Name = "button2";
            button2.Size = new Size(118, 117);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(118, 117);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tmrTimeElapse
            // 
            tmrTimeElapse.Enabled = true;
            tmrTimeElapse.Tick += tmrTimeElapse_Tick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 499);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(btnReset);
            Controls.Add(groupBox1);
            Controls.Add(viewMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Tic Tac Toe";
            viewMenu.ResumeLayout(false);
            viewMenu.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
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
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button button10;
        private Button btnReset;
        private GroupBox groupBox1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private System.Windows.Forms.Timer tmrTimeElapse;
    }
}