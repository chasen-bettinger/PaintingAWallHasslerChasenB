using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingAWallHasslerChasenB
{
    class Wall
    {
        private uint wallWidth;
        private uint wallHeight;
        private uint numOfDoorways;

        public Wall(uint wallWidth, uint wallHeight, uint numOfDoorways)
        {
            this.wallWidth = wallWidth;
            this.wallHeight = wallHeight;
            this.numOfDoorways = numOfDoorways;
        }

        public uint getWallArea()
        {
            return wallWidth * wallHeight;
        }

        public uint getAreaOfDoorways()
        {
            return numOfDoorways * 14;
        }
    }
}
