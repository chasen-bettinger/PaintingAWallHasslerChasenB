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

        public double getNumOfGallons(double areaToPaint)
        {
            return areaToPaint / 350.0;
        }

        public double getCostOfPaint(double numOfGallons)
        {
            return costOfPaint * numOfGallons;
        }
    }
}
