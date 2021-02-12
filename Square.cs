using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_tak_toe
{
    public enum Player { Nobody = 0, Noughts, Crosses }
     
    public struct Squere
    {
        public Player Owner { get; }

        public Squere(Player owner)

        {
            this.Owner = owner;
        }
        public override string ToString()
        {
            switch (Owner)
            {
                case Player.Nobody:
                    return ".";
                case Player.Noughts:
                    return "O";
                case Player.Crosses:
                    return "X";
                default:
                    throw new Exception("Invalid state");
            }
        }
    }
    
}
