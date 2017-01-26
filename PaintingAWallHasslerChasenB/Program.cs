using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PaintingAWallHasslerChasenB
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, width;
            int numOfDoorways;
            Wall wall;
            Paint paint;
            double costOfPaint;
            bool isDouble = false;
            bool isInt = false;
            ArrayList list = new ArrayList();
            String line;
            

            StreamReader streamReader = new StreamReader("C:\\Users\\bettingercr\\Desktop\\2of12.txt");
            line = streamReader.ReadLine();
            while(line != null)
            {
                list.Add(line);
            }
         
            do
            {
                Console.WriteLine("Enter the length of the wall");
                isDouble = double.TryParse(Console.ReadLine(), out height);
                if(!isDouble)
                {
                    Console.WriteLine("Please enter a decimal value\n");
                }
                else
                {
                    Console.WriteLine("");
                }
          
            } while (!isDouble);

            do
            {
                Console.WriteLine("Enter the width of the wall");
                isDouble = double.TryParse(Console.ReadLine(), out width);
                if (!isDouble)
                {
                    Console.WriteLine("Please enter a decimal value\n");
                }
                else
                {
                    Console.WriteLine("");
                }

            } while (!isDouble);

            do
            {
                Console.WriteLine("Enter the number of doorways that you wish not to paint");
                isInt = int.TryParse(Console.ReadLine(), out numOfDoorways);
                if (!isInt)
                {
                    Console.WriteLine("Please enter an integer value\n");
                }
                else
                {
                    Console.WriteLine("");
                }

            } while (!isInt);

            do
            {
                Console.WriteLine("Enter the cost of paint");
                isDouble = double.TryParse(Console.ReadLine(), out costOfPaint);
                if (!isDouble)
                {
                    Console.WriteLine("Please enter a decimal value\n");
                }
                else
                {
                    Console.WriteLine("");
                }

            } while (!isDouble);

            wall = new Wall(width, height, numOfDoorways);
            paint = new Paint(costOfPaint);

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
