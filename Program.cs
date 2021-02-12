using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_tak_toe
{class Program
    {
        static void  Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            
            Console.WriteLine(">>>>>>>>>>>>>TIK-TAK-TOE<<<<<<<<<<<<<<<<<");
            Console.SetCursorPosition(0,3);
            Game game = new Game();
            game.PlayGame();
            
            Console.WriteLine("Game over");

        }
    }
    

}
