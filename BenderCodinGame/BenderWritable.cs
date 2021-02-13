using System;
using System.Collections.Generic;
using System.Text;

namespace BenderCodinGame
{
    //...I need two states for Bender: for writing steps and count state...
    class BenderWritable : Bender
    {
        public BenderWritable(int positionX, int positionY) : base(positionX, positionY)
        {
        }

        public override void GoUp()
        {
            base.GoUp();
            Console.WriteLine("NORTH");
        }
        public override void GoDown()
        {
            base.GoDown();
            Console.WriteLine("SOUTH");
        }
        public override void GoLeft()
        {
            base.GoLeft();
            Console.WriteLine("WEST");
        }
        public override void GoRight()
        {
            base.GoRight();
            Console.WriteLine("EAST");
        }
    }
}
 