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

        public View(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public void button_click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            string tempTag = temp.Tag.ToString();
            _controller.button_pressed(tempTag);
        }

        public void restart_click(object sender, EventArgs e)
        {

        }

        void IObserver.Update(object Model)
        {
            Model model = (Model)Model;
        }
    }
}
