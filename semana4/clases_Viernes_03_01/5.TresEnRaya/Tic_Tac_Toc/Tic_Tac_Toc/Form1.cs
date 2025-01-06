namespace Tic_Tac_Toc
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusOne;

        public void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        public void Score()
        {
            #region Player X
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button8.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;

                MessageBox.Show("Player X Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayerX.Text);
                labelPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }
            #endregion

            #region Player O
            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button2.Text == "0" && button5.Text == "0" && button8.Text == "0")
            {
                button2.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button8.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }
            if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }
            if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                button3.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;

                MessageBox.Show("Player 0 Wins", "Tic Tac Toc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = Convert.ToInt32(labelPlayer0.Text);
                labelPlayer0.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }
            #endregion
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "0";
                checker = false;
            }
            Score();
            button1.Enabled = false;
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
                button4.Text = "0";
                checker = false;
            }
            Score();
            button4.Enabled = false;
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
                button2.Text = "0";
                checker = false;
            }
            Score();
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
                button3.Text = "0";
                checker = false;
            }
            Score();
            button3.Enabled = false;
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
                button5.Text = "0";
                checker = false;
            }
            Score();
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
                button6.Text = "0";
                checker = false;
            }
            Score();
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
                button7.Text = "0";
                checker = false;
            }
            Score();
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
                button8.Text = "0";
                checker = false;
            }
            Score();
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
                button9.Text = "0";
                checker = false;
            }
            Score();
            button9.Enabled = false;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            labelPlayerX.Text = "0";
            labelPlayer0.Text = "0";

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show(
                "Confirm if you want to exit", "Tic Tac Toc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1Reset_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            buttonNewGame.Enabled = true;

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }
    }
}
