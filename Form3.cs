using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProgGame
{
    public partial class Form3 : Form
    {
        int rounds = 5;
        int timerPerRound = 6;

        bool gameover = false;

        string[] CPUchoiceList = { "rock", "paper", "scissor", "paper", "scissor", "rock" };

        int randomNumber = 0;

        Random rnd = new Random();

        string CPUchoice;

        string playerChoice;

        int playerwins;
        int AIwins;

        public Form3()
        {
            InitializeComponent();
            InitializeMenu();
            countDownTimer.Enabled = true;
            playerChoice = "none";
            txtTime.Text = "5";
        }

        private void InitializeMenu()
        {
            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem viewMenu = new ToolStripMenuItem("View");
            ToolStripMenuItem anothergameItem = new ToolStripMenuItem("Anothergame", null, moregameDropdown);
            ToolStripMenuItem mainscreenItem = new ToolStripMenuItem("Mainscreen", null, mainscreenDropdown);
            ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit", null, exitDropdown);

            viewMenu.DropDownItems.Add(moregameDropdown);
            viewMenu.DropDownItems.Add(mainscreenDropdown);
            viewMenu.DropDownItems.Add(new ToolStripSeparator());
            viewMenu.DropDownItems.Add(exitDropdown);

            menuStrip.Items.Add(viewMenu);

            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;
        }

        private void mainscreenDropdown_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void exitDropdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void puzzleDropdown_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            this.Hide();
            form2.Show();
        }

        private void tictactoeDropdown_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            this.Hide();
            form4.Show();
        }

        private void savethechickenDropdown_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Close();
            this.Hide();
            form5.Show();
        }

        private void flyingufoDropdown_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Close();
            this.Hide();
            form6.Show();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.left_rock;
            playerChoice = "rock";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.left_paper;
            playerChoice = "paper";
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.left_scissors;
            playerChoice = "scissor";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            restartGame(sender, e);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            timerPerRound -= 1;

            txtTime.Text = timerPerRound.ToString();
            roundsText.Text = "Rounds: " + rounds;

            if (timerPerRound < 1)
            {
                countDownTimer.Enabled = false;
                timerPerRound = 6;

                randomNumber = rnd.Next(0, CPUchoiceList.Length);

                CPUchoice = CPUchoiceList[randomNumber];

                switch (CPUchoice)
                {
                    case "rock":
                        picComputer.Image = Properties.Resources.right_rock;
                        break;
                    case "paper":
                        picComputer.Image = Properties.Resources.right_paper;
                        break;
                    case "scissor":
                        picComputer.Image = Properties.Resources.right_scissors;
                        break;
                }


                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if (playerwins > AIwins)
                    {
                        MessageBox.Show("Player Wins This Game");
                    }
                    else
                    {
                        MessageBox.Show("CPU Wins This Game");
                    }

                    gameover = true;
                }
            }
        }
        private void checkGame()
        {

            // AI and player win rules

            if (playerChoice == "rock" && CPUchoice == "paper")
            {

                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins, Paper Covers Rocks");

            }
            else if (playerChoice == "scissor" && CPUchoice == "rock")
            {
                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins, Rock Breaks Scissors");
            }
            else if (playerChoice == "paper" && CPUchoice == "scissor")
            {

                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins, Scissor cuts paper");

            }
            else if (playerChoice == "rock" && CPUchoice == "scissor")
            {

                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Rock Breaks Scissors");

            }
            else if (playerChoice == "paper" && CPUchoice == "rock")
            {

                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Paper Covers Rocks");

            }
            else if (playerChoice == "scissor" && CPUchoice == "paper")
            {
                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Scissor cuts paper");

            }
            else if (playerChoice == "none")
            {
                MessageBox.Show("Make your Choice");
            }
            else
            {
                MessageBox.Show("Draw");

            }

            startNextRound();
        }
        public void startNextRound()
        {

            if (gameover)
            {
                return;
            }

            txtMessagePlayer.Text = "" + playerwins;
            txtMessageComputer.Text = "" + AIwins;

            playerChoice = "none";

            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;
            picComputer.Image = Properties.Resources.qq;
        }

        private void restartGame(object sender, EventArgs e)
        {
            playerwins = 0;
            AIwins = 0;
            rounds = 5;
            txtMessagePlayer.Text = "" + playerwins;
            txtMessageComputer.Text = "" + AIwins;

            playerChoice = "none";
            txtTime.Text = "5";

            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;
            picComputer.Image = Properties.Resources.qq;

            gameover = false;
        }
    }
}
