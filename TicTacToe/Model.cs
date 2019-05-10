using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Model : Observable
    {
        int turn1;
        int [] board;
        int winner = 0;
        int rounds = 0;

        public Model()
        {
            turn1 = 1;
            board = new int[9];
        }

        public void startGame()
        {
            for(int i = 0; i < 9; i++)
            {
                board[i] = 0;
                rounds = 0;
                winner = 0;
            }
            turn1 = 1;
            SetChanged();
            NotifyObservers();
        }

        public void updateBoard(int pos)
        {
            board[pos] = turn1;
            turn1 *= -1;
            rounds++;
            checkWin();
            checkTie();
            SetChanged();
            NotifyObservers();
        }

        public void checkWin()
        {
            //horisontellt
            if(board[0] == board[1] && board[1] == board[2])
            {
                winner = board[0];
            }
            else if (board[3] == board[4] && board[4] == board[5])
            {
                winner = board[3];
            }
            else if (board[6] == board[7] && board[7] == board[8])
            {
                winner = board[6];
            }
            //vertikalt
            else if (board[0] == board[3] && board[3] == board[6])
            {
                winner = board[0];
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
                winner = board[1];
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                winner = board[2];
            }
            //diagonalt
            else if (board[0] == board[4] && board[4] == board[8])
            {
                winner = board[0];
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                winner = board[2];
            }
        }
        
        public int[] getboard()
        {
            return board;
        }

        public int getWinner()
        {
            return winner;
        }

        public void checkTie()
        {
            if(rounds > 8 && winner == 0)
            {
                winner = 0;
            }
        }
    }
}
