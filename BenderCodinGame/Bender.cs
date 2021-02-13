using System;
using System.Collections.Generic;
using System.Text;

namespace BenderCodinGame
{
    public class Bender
    {
        public int positionX;
        public int positionY;
        public int wayvalue;

        public Bender(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
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
            this.positionY--;
        }

        public void GoLeft()
        {
            this.positionX--;
        }

        public void GoUp()
        {
            this.positionY++;
        }

        public void GoRight()
        {
            this.positionX++;
        }
    }
}
