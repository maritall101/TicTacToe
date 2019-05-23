using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class View : Form, IObserver
    {
        Controller _controller;
        private string Playername1;
        private string Playername2;
        private Button[] buttonArray;

        public View(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
            buttonArray = new Button[9];
            buttonArray[0] = GameButton1;
            buttonArray[1] = GameButton2;
            buttonArray[2] = GameButton3;
            buttonArray[3] = GameButton4;
            buttonArray[4] = GameButton5;
            buttonArray[5] = GameButton6;
            buttonArray[6] = GameButton7;
            buttonArray[7] = GameButton8;
            buttonArray[8] = GameButton9;
        }

        public View()
        {
            InitializeComponent();
        }

        public void button_click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            string tempTag = temp.Tag.ToString();
            _controller.button_pressed(tempTag);
        }

        void IObserver.Update(object Model)
        {
            Model model = (Model)Model;
            int winner = model.getWinner();
            int[] temp = model.getboard();

            if(winner != 0)
            {
                if(winner == 1)
                {
                    System.Windows.Forms.MessageBox.Show(Playername1 + " won!");
                }
                else if(winner == -1)
                {
                    System.Windows.Forms.MessageBox.Show(Playername2 + " won!");
                }
                else if(winner == 2)
                {
                    System.Windows.Forms.MessageBox.Show("It´s a tie!");
                }
            }

            for(int i = 0; i < 9; i++)
            {
                if(temp[i] == 1)
                {
                    buttonArray[i].Text = "X";
                    buttonArray[i].Enabled = false;
                }
                else if(temp[i] == -1)
                {
                    buttonArray[i].Text = "O";
                    buttonArray[i].Enabled = false;
                }
                else if (temp[i] == 0)
                {
                    buttonArray[i].Text = "";
                    buttonArray[i].Enabled = true;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Playername1 = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Playername2 = textBox1.Text;
        }

        private void Restart_Click_1(object sender, EventArgs e)
        {
            _controller.restartButton_pressed();
        }
    }
}
