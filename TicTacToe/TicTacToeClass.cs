using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeClass
    {
        public void UC1Method()
        {
            char[] board = new char[10];


            int entry = Convert.ToInt32(Console.ReadLine());

            board[entry - 1] = 'X';
        }
    }
}
