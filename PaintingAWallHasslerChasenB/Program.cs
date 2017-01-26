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
            double length, width;
            uint numOfDoorways;
            Wall wall = new Wall(0, 0, 0);
            Paint paint = new Paint(0.00);
            double costOfPaint = 0.00;
           

            Console.WriteLine("Enter the length of the wall");
            if(double.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Enter the width of the wall");
                if(double.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Enter the number of doorways you wish to not paint");
                    if(uint.TryParse(Console.ReadLine(), out numOfDoorways))
                    {
                        wall = new Wall(width, length, numOfDoorways);
                        Console.WriteLine("Enter the cost of paint");
                        if(double.TryParse(Console.ReadLine(), out costOfPaint))
                        {
                            paint = new Paint(costOfPaint);
                        }
                    }
                }
            }
          

            double areaToPaint = wall.getWallArea() - wall.getAreaOfDoorways();

            double numOfGallons = paint.getNumOfGallons(areaToPaint);
            double costOfAllPaint = paint.getCostOfPaint(numOfGallons);

            String costOfPaintInUSCurrency = costOfAllPaint.ToString("C", CultureInfo.CurrentCulture);
            String gallonString = numOfGallons.ToString("0.##");
            Console.WriteLine("I need {0} gallons of paint. That will cost me {1}.", gallonString, costOfPaintInUSCurrency);

            Console.Read();
        }
    }
}
