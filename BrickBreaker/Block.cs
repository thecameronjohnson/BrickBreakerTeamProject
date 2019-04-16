using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    public class Block
    {
        public int width = 50;
        public int height = 25;

        public int x;
        public int y; 
        public int hp;
        public Color colour;

        public static Random rand = new Random();

        public Block(int _x, int _y, int _hp)
        {
            x = _x;
            y = _y;
            hp = _hp;
            switch (_hp)
            {
                case 1:
                    colour = Color.Red;
                    break;
                case 2:
                    colour = Color.Yellow;
                    break;
                case 3:
                    colour = Color.Green;
                    break;
                case 4:
                    colour = Color.Cyan;
                    break;
            }
        }
    }
}
