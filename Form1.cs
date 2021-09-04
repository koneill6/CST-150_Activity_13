using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            turnLabel.Text = "O";
        }
        //starts the game with O's
        bool isXTurn = false;
        
        String winner = "";

        //creates 2D array to keep track
        String[,] gameBoard = new string[3, 3];

        void turnLabelUpdate()
        {
            if (isXTurn)
            {
                turnLabel.Text = "X";
            }
            else
            {
                turnLabel.Text = "O";
            }
        }

        bool didSomeoneWin()
        {
            //Check if top row are all the same
            if(gameBoard[0,0] == "X" && gameBoard[0,1] == "X" && gameBoard[0, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[0, 0] == "O" && gameBoard[0, 1] == "O" && gameBoard[0, 2] == "O")
            {
                winner = "O";
                return true;
            }

            //Check if middle row are all the same
            if (gameBoard[1, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[1, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[1, 0] == "O" && gameBoard[1, 1] == "O" && gameBoard[1, 2] == "O")
            {
                winner = "O";
                return true;
            }

            //Check if bottom row is the same
            if (gameBoard[2, 0] == "X" && gameBoard[2, 1] == "X" && gameBoard[2, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[2, 0] == "O" && gameBoard[2, 1] == "O" && gameBoard[2, 2] == "O")
            {
                winner = "O";
                return true;
            }

            //Check if left column is the same
            if (gameBoard[0, 0] == "X" && gameBoard[1, 0] == "X" && gameBoard[2,0] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[0, 0] == "O" && gameBoard[1, 0] == "O" && gameBoard[2, 0] == "O")
            {
                winner = "O";
                return true;
            }

            //check if middle column are all the same
            if (gameBoard[0, 1] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 1] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[0, 1] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 1] == "O")
            {
                winner = "O";
                return true;
            }

            //Check if right column is the same
            if (gameBoard[0, 2] == "X" && gameBoard[1, 2] == "X" && gameBoard[2, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[0, 2] == "O" && gameBoard[1, 2] == "O" && gameBoard[2, 2] == "O")
            {
                winner = "O";
                return true;
            }

            //check if upper left to bottom right diagnal is the same
            if (gameBoard[0, 0] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 2] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[0, 0] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 2] == "O")
            {
                winner = "O";
                return true;
            }

            //check if upper right to bottom left diagnal is the same
            if (gameBoard[0, 2] == "X" && gameBoard[1, 1] == "X" && gameBoard[2, 0] == "X")
            {
                winner = "X";
                return true;
            }

            if (gameBoard[0, 2] == "O" && gameBoard[1, 1] == "O" && gameBoard[2, 0] == "O")
            {
                winner = "O";
                return true;
            }

            return false;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isXTurn)
            {
                button1.Text = "X";
                gameBoard[0,0] = "X";
                isXTurn = false;
                turnLabelUpdate();
            }
            else
            {
                button1.Text = "O";
                gameBoard[0, 0] = "O";
                isXTurn = true;
                turnLabelUpdate();
            }

            bool won = didSomeoneWin();
            if (won)
            {
                MessageBox.Show(winner + " Won!!!!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isXTurn)
            {
                button2.Text = "X";
                gameBoard[0, 1] = "X";
                isXTurn = false;
                turnLabelUpdate();
            }
            else
            {
                button2.Text = "O";
                gameBoard[0, 1] = "O";
                isXTurn = true;
                turnLabelUpdate();
            }

            bool won = didSomeoneWin();
            if (won)
            {
                MessageBox.Show(winner + " Won!!!!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isXTurn)
            {
                button3.Text = "X";
                gameBoard[0, 2] = "X";
                isXTurn = false;
                turnLabelUpdate();
            }
            else
            {
                button3.Text = "O";
                gameBoard[0, 2] = "O";
                isXTurn = true;
                turnLabelUpdate();
            }

            bool won = didSomeoneWin();
            if (won)
            {
                MessageBox.Show(winner + " Won!!!!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isXTurn)
            {
                button4.Text = "X";
                gameBoard[1, 0] = "X";
                isXTurn = false;
                turnLabelUpdate();
            }
            else
            {
                button4.Text = "O";
                gameBoard[1, 0] = "O";
                isXTurn = true;
                turnLabelUpdate();
            }

            bool won = didSomeoneWin();
            if (won)
            {
                MessageBox.Show(winner + " Won!!!!!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isXTurn)
            {
                button5.Text = "X";
                gameBoard[1, 1] = "X";
                isXTurn = false;
                turnLabelUpdate();
            }
            else
            {
                button5.Text = "O";
                gameBoard[1, 1] = "O";
                isXTurn = true;
                turnLabelUpdate();
            }

            bool won = didSomeoneWin();
            if (won)
            {
                MessageBox.Show(winner + " Won!!!!!!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isXTurn)
            {
                button6.Text = "X";
                gameBoard[1, 2] = "X";
                isXTurn = false;
                turnLabelUpdate();
            }
            else
            {
                button6.Text = "O";
                gameBoard[1, 2] = "O";
                isXTurn = true;
                turnLabelUpdate();
            }

            bool won = didSomeoneWin();
            if (won)
            {
                MessageBox.Show(winner + " Won!!!!!!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isXTurn)
            {
                button7.Text = "X";
                gameBoard[2, 0] = "X";
                isXTurn = false;
                turnLabelUpdate();
            }
            else
            {
                button7.Text = "O";
                gameBoard[2, 0] = "O";
                isXTurn = true;
                turnLabelUpdate();
            }

            bool won = didSomeoneWin();
            if (won)
            {
                MessageBox.Show(winner + " Won!!!!!!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isXTurn)
            {
                button8.Text = "X";
                gameBoard[2, 1] = "X";
                isXTurn = false;
                turnLabelUpdate();
            }
            else
            {
                button8.Text = "O";
                gameBoard[2, 1] = "O";
                isXTurn = true;
                turnLabelUpdate();
            }

            bool won = didSomeoneWin();
            if (won)
            {
                MessageBox.Show(winner + " Won!!!!!!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isXTurn)
            {
                button9.Text = "X";
                gameBoard[2, 2] = "X";
                isXTurn = false;
                turnLabelUpdate();
            }
            else
            {
                button9.Text = "O";
                gameBoard[2, 2] = "O";
                isXTurn = true;
                turnLabelUpdate();
            }

            bool won = didSomeoneWin();
            if (won)
            {
                MessageBox.Show(winner + " Won!!!!!!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            Array.Clear(gameBoard,0,gameBoard.Length);
        }
    }
}
