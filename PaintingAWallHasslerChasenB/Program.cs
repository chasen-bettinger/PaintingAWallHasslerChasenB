using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingAWallHasslerChasenB
{
    class Program
    {
        static void Main(string[] args)
        {

            Wall wall = new Wall(25, 25, 3);

            uint areaToPaint = wall.getWallArea() - wall.getAreaOfDoorways();

            Paint paint = new Paint(15.30);

            uint numOfGallons = paint.getNumOfGallons(areaToPaint);
            double costOfPaint = paint.getCostOfPaint(numOfGallons);

            String costOfPaintInUSCurrency = costOfPaint.ToString("C", CultureInfo.CurrentCulture);
            Console.WriteLine("I need {0} gallons of paint. That will cost me {1}.", numOfGallons, costOfPaintInUSCurrency);

            Console.Read();
        }
    }
}
