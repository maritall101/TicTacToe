using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Controller
    {
        Model _model;
        public Controller(Model model)
        {
            _model = model;
        }
        public void button_pressed(string tempString)
        {
            _model.updateBoard(Convert.ToInt32(tempString));   //gör om string till int. skickar int till updateBoard
        }

        public void restartButton_pressed()
        {
            _model.startGame();   
        }

    }    
}
