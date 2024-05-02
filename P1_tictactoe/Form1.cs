using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_tictactoe
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusOne;

        void enabler(Boolean val)
        {
            button1.Enabled = val;
            button2.Enabled = val;
            button3.Enabled = val;
            button4.Enabled = val;
            button5.Enabled = val;
            button6.Enabled = val;
            button7.Enabled = val;
            button8.Enabled = val;
            button9.Enabled = val;
        }

        void score()
        {
            // Row wise
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X","Tic Tac Toe",MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label5.Text);
                label5.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label5.Text);
                label5.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label5.Text);
                label5.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            // Column wise
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label5.Text);
                label5.Text = (plusOne+1).ToString();
                enabler(false);
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label5.Text);
                label5.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label5.Text);
                label5.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            // Diagonal Wise
            if (button9.Text == "X" && button5.Text == "X" && button1.Text == "X")
            {
                button9.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button1.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label5.Text);
                label5.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                button7.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label5.Text);
                label5.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            // --------------------------------------------------------------------------------------------------------------- //

            // Row wise
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button3.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button1.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label4.Text);
                label4.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label4.Text);
                label4.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label4.Text);
                label4.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            // Column wise
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label4.Text);
                label4.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label4.Text);
                label4.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button9.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label4.Text);
                label4.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            // Diagonal Wise
            if (button9.Text == "O" && button5.Text == "O" && button1.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label4.Text);
                label4.Text = (plusOne + 1).ToString();
                enabler(false);
            }

            if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                button7.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(label4.Text);
                label4.Text = (plusOne + 1).ToString();
                enabler(false);
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            score();
            button1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            score();
            button2.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            score();
            button3.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            score();
            button4.Enabled = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            score();
            button5.Enabled = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            score();
            button6.Enabled = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            score();
            button7.Enabled = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            score();
            button8.Enabled = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            score();
            button9.Enabled = false;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            // Reset
            try {

                enabler(true);

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;

                button12.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            // Exit
            try 
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Do you want to exit?","Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(iExit == DialogResult.Yes) {
                    Application.Exit();
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            // New Game
            try
            {
                enabler(true);

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;

                label5.Text = "0";
                label4.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
