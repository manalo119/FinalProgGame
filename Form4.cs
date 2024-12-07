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
    public partial class Form4 : Form
    {
        private bool player1_turn = true;
        private int[,] boardValue = new int[3, 3];
        const int X_VALUE = 1;
        const int O_VALUE = 2;

        public Form4()
        {
            InitializeComponent();
            restart_matrix();
            player1_turn = true;
        }

        private void tmrTimeElapse_Tick(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Black;
            }
            else
            {
                label2.ForeColor = Color.Green;
                label1.ForeColor = Color.Black;
            }
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

        private void savethechickenDropdown_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Close();
            this.Hide();
            form5.Show();
        }

        private void flyingufoDropdown_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Close();
            this.Hide();
            form5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 0] = O_VALUE;
            }

            check_win();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 1] = O_VALUE;
            }
            check_win();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[0, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[0, 2] = O_VALUE;
            }
            check_win();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 0] = O_VALUE;
            }
            check_win();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 1] = O_VALUE;
            }
            check_win();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[1, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[1, 2] = O_VALUE;
            }
            check_win();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 0] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 0] = O_VALUE;
            }
            check_win();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 1] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 1] = O_VALUE;
            }
            check_win();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (player1_turn == true)
            {
                player1_turn = false;
                ((Button)sender).Text = "X";
                boardValue[2, 2] = X_VALUE;
            }
            else
            {
                player1_turn = true;
                ((Button)sender).Text = "O";
                boardValue[2, 2] = O_VALUE;
            }
            check_win();
        }
        private void check_win()
        {
            // Check rows
            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(boardValue[i, 0]) == Convert.ToInt32(boardValue[i, 1]) &&
                    Convert.ToInt32(boardValue[i, 1]) == Convert.ToInt32(boardValue[i, 2]) &&
                    Convert.ToInt32(boardValue[i, 1]) != 0)
                {
                    color_winning_buttons(find_button_by_value(i, 0),
                        find_button_by_value(i, 1),
                        find_button_by_value(i, 2));
                    display_win_screen(boardValue[i, 0]);

                    return;
                }
            }

            // Check columns
            for (int i = 0; i < 3; ++i)
            {
                if (Convert.ToInt32(boardValue[0, i]) == Convert.ToInt32(boardValue[1, i]) &&
                    Convert.ToInt32(boardValue[1, i]) == Convert.ToInt32(boardValue[2, i]) &&
                    Convert.ToInt32(boardValue[2, i]) != 0)
                {
                    color_winning_buttons(find_button_by_value(0, i),
                        find_button_by_value(1, i),
                        find_button_by_value(2, i));
                    display_win_screen(boardValue[1, i]);
                    return;
                }
            }

            // Check diagonals
            if (Convert.ToInt32(boardValue[0, 0]) == Convert.ToInt32(boardValue[1, 1]) &&
                Convert.ToInt32(boardValue[1, 1]) == Convert.ToInt32(boardValue[2, 2]) &&
                Convert.ToInt32(boardValue[2, 2]) != 0)
            {
                color_winning_buttons(find_button_by_value(0, 0),
                    find_button_by_value(1, 1),
                    find_button_by_value(2, 2));
                display_win_screen(boardValue[1, 1]);
                return;
            }
            else if (Convert.ToInt32(boardValue[0, 2]) == Convert.ToInt32(boardValue[1, 1]) &&
              Convert.ToInt32(boardValue[1, 1]) == Convert.ToInt32(boardValue[2, 0]) &&
              Convert.ToInt32(boardValue[2, 0]) != 0)
            {
                color_winning_buttons(find_button_by_value(0, 2),
                    find_button_by_value(1, 1),
                    find_button_by_value(2, 0));
                display_win_screen(boardValue[1, 1]);
                return;
            }

            // Check draw
            bool is_completed = true;
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; j++)
                    if (boardValue[i, j] == 0)
                        is_completed = false;
            if (is_completed)
            {
                MessageBox.Show("Draw");
                restart_matrix();
            }
        }
        private void display_win_screen(int val)
        {
            if (val == X_VALUE)
            {
                MessageBox.Show("Player1 wins!");
                int player1_score = Convert.ToInt32(label4.Text);
                ++player1_score;
                label4.Text = player1_score.ToString();
            }
            else
            {
                MessageBox.Show("Player2 wins!");
                int player2_score = Convert.ToInt32(label5.Text);
                ++player2_score;
                label5.Text = player2_score.ToString();
            }

            restart_matrix();
        }

        // Restart tic tac toe board
        private void restart_matrix()
        {
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    boardValue[i, j] = 0;

            clear_buttons();
            player1_turn = true;
        }

        // Color winning buttons
        private void color_winning_buttons(Button button1, Button button2, Button button3)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
        }

        // Clear buttons
        private void clear_buttons()
        {
            // Content
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            // Back color
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Green;
            button9.BackColor = Color.Green;

            // Fore color
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button9.ForeColor = Color.White;
        }

        // Find a button by it's value
        private Button find_button_by_value(int value_x, int value_y)
        {
            if (value_x == 0)
            {
                if (value_y == 0) return button1;
                if (value_y == 1) return button2;
                if (value_y == 2) return button3;
            }
            else if (value_x == 1)
            {
                if (value_y == 0) return button4;
                if (value_y == 1) return button5;
                if (value_y == 2) return button6;
            }
            else if (value_x == 2)
            {
                if (value_y == 0) return button7;
                if (value_y == 1) return button8;
                if (value_y == 2) return button9;
            }

            // If no match, return a default action.
            MessageBox.Show("Invalid board position detected!");
            return null;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
