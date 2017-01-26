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
        private const double GALLONAREA = 350.0;

        public Paint(double costOfPaint)
        {
            this.costOfPaint = costOfPaint;
        }

        public double getNumOfGallons(double areaToPaint)
        {
            return areaToPaint / GALLONAREA;
        }

        public double getCostOfPaint(double numOfGallons)
        {
            return costOfPaint * numOfGallons;
        }
    }
}
