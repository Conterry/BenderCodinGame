using System;
using System.Collections.Generic;
using System.Text;

namespace BenderCodinGame
{
    class Bender
    {
        public int positionX;
        public int positionY;
        public int wayvalue;

        public Bender(int posX, int posY)
        {
            this.positionX = posX;
            this.positionY = posY;
            this.wayvalue = 0;
        }

        public void SetWay(char way)
        {
            switch (way)
            {
                case 'S':
                    wayvalue = 0;
                    break;
                case 'E':
                    wayvalue = 1;
                    break;
                case 'N':
                    wayvalue = 2;
                    break;
                case 'W':
                    wayvalue = 3;
                    break;
            }
        }

        public void SetNextWay()
        {
            if (this.wayvalue == 3)
            {
                this.wayvalue = 0;
            }
            else
            {
                this.wayvalue++;
            }
        }

        public void GoInWay()
        {
            int way = this.wayvalue;
            switch (way)
            {
                case 0:
                    GoDown();
                    break;
                case 1:
                    GoLeft();
                    break;
                case 2:
                    GoUp();
                    break;
                case 3:
                    GoRight();
                    break;

            }
        }

        public void GoDown()
        {

        }

        public void GoLeft()
        {

        }

        public void GoUp()
        {

        }

        public void GoRight()
        {

        }
    }
}
