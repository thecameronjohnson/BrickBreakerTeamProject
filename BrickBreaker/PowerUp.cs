using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    class PowerUp
    {
        public int powerValue;
        public int x, y, powerSpeed, size;
        public Color colour;

        // create a random number generator 
       

        public PowerUp(int _x, int _y, int _powerSpeed, int _size, int _powerValue)
        {
            x = _x;
            y = _y;
            powerSpeed = _powerSpeed;
            size = _size;
            powerValue = _powerValue;
        }

        public Boolean PowerUpCollision(Paddle p)
        {
            Rectangle powerUpRec = new Rectangle(x, y, size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            return (powerUpRec.IntersectsWith(paddleRec));
        }

        public Color UpdateColour()
        {
           return Color.Blue;
        }

        //move the power up down the screen
        public void Move()
        {
            y = y + powerSpeed;
        }
    }
}
