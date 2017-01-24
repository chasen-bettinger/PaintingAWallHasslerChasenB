using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingAWallHasslerChasenB
{
    class Paint
    {

        private double costOfPaint;
        private uint numOfGallons;

        public Paint(double costOfPaint)
        {
            this.costOfPaint = costOfPaint;
        }

        public uint getNumOfGallons(uint areaToPaint)
        {
            return areaToPaint / 350;
        }

        public double getCostOfPaint(uint numOfGallons)
        {
            return (double) costOfPaint * numOfGallons;
        }
    }
}
