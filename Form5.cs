using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FinalProgGame
{
    public partial class Form5 : Form
    {
        bool goleft, goright;

        int speed = 8;
        int score = 0;
        int health = 5;

        Random randX = new Random();
        Random randY = new Random();

        PictureBox splash = new PictureBox();
        public Form5()
        {
            InitializeComponent();
            InitializeMenu();
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

        private void rockpaperscissorsDropdown_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Close();
            this.Hide();
            form3.Show();
        }

        private void tictactoeDropdown_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Close();
            this.Hide();
            form4.Show();
        }

        private void flyingufoDropdown_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Close();
            this.Hide();
            form6.Show();
        }

        private void gameTick(object sender, EventArgs e)
        {
            txtScore.Text = "Egg Caught: " + score;
            txtHealth.Text = "Health: " + health;

            if (goleft == true && chicken.Left > 0)
            {
                chicken.Left -= 12;
                chicken.Image = Properties.Resources.chicken_normal2;
            }
            if (goright == true && chicken.Left + chicken.Width < this.ClientSize.Width)
            {
                chicken.Left += 12;
                chicken.Image = Properties.Resources.chicken_normal;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "eggs")
                {
                    x.Top += speed;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        splash.Image = Properties.Resources.splash;
                        splash.Location = x.Location;
                        splash.Height = 60;
                        splash.Width = 60;
                        splash.BackColor = Color.Transparent;
                        this.Controls.Add(splash);

                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        health -= 1;
                        chicken.Image = Properties.Resources.chicken_hurt;
                    }

                    if (chicken.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = randY.Next(-300, -50);
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        score += 1;

                        if (score % 10 == 0 && health < 5)
                        {
                            health += 1;
                        }
                    }
                }
            }

            if (score > 10)
            {
                speed = 12;
            }

            if (health <= 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over!" + Environment.NewLine +
                                "Your health is gone!" + Environment.NewLine +

                                "Click OK to retry");
                reset();
            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }
        private void reset()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "eggs")
                {
                    x.Top = randY.Next(-300, -50);
                    x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                }
            }

            chicken.Left = this.ClientSize.Width / 2;
            chicken.Image = Properties.Resources.chicken_normal;

            score = 0;
            health = 5;
            speed = 8;

            goleft = false;
            goright = false;

            gameTimer.Start();
        }
    }
}
