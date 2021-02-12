using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tik_tak_toe
{
    class Game
    {
        private Squere[ , ]_board = new Squere[3, 3];
        //private Squere[][] _board =
        //{
        //    new Squere[3],
        //    new Squere[3],
        //    new Squere[3]
        //};
        public void PlayGame()
        {
            Player player = Player.Crosses;

            bool @continue = true;

            // @ used to tell compailer that is a variable and not 
            // C# statement

          while (@continue)
            {
                DisplayBoard();                
                @continue = PlayMove(player);
                if (!@continue)
                    return;
                player = 3 - player;
            }
        }
        private void DisplayBoard()
        {
            for (int i = 0; i < 3; i++) //nested for loop are very often used for iterating trought 
                // jagged arrays
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(" " + _board[i,j]);
                Console.WriteLine();
            }
        }
        private bool PlayMove(Player player)
        {
            
            Console.WriteLine("Ivalid input stops game");
            Console.WriteLine($"{player}: Enter row comma column, eg. 3,3> ");
            string input = Console.ReadLine();
            string[] parts = input.Split(',');
            if (parts.Length != 2)
                return false;
            int.TryParse(parts[0], out int row);
            int.TryParse(parts[1], out int column);

            if (row < 1 || row > 3 || column < 1 || column > 3)
                return false;

            if (_board[row-1,column-1].Owner != Player.Nobody)
            {
                Console.WriteLine("Square is already occupied");
                return false;
            }
            _board[row - 1,column - 1] = new Squere(player);
            return true;
        }
    }
}
