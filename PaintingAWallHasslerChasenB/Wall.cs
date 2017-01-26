using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingAWallHasslerChasenB
{
    class Wall
    {
        private double wallWidth;
        private double wallHeight;
        private uint numOfDoorways;

        public Wall(double wallWidth, double wallHeight, uint numOfDoorways)
        {
            this.wallWidth = wallWidth;
            this.wallHeight = wallHeight;
            this.numOfDoorways = numOfDoorways;
        }

        public double getWallArea()
        {
            return wallWidth * wallHeight;
        }

        public uint getAreaOfDoorways()
        {
            return numOfDoorways * 14;
        }
    }
}
