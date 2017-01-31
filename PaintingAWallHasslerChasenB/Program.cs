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
            
            // Determine height of wall based on user input
            do
            {
                Console.WriteLine("Enter the length of the wall");
                isDouble = double.TryParse(Console.ReadLine(), out height);
                if(!isDouble)
                {
                    Console.WriteLine("Please enter a decimal value\n");
                }
                // If the user didn't enter a double, they are asked for input once again
                else
                {
                    Console.WriteLine("");
                }
          
            } while (!isDouble);

            // Determine width of wall based on user input
            do
            {
                Console.WriteLine("Enter the width of the wall");
                isDouble = double.TryParse(Console.ReadLine(), out width);
                if (!isDouble)
                {
                    Console.WriteLine("Please enter a decimal value\n");
                }
                // If the user didn't enter a double, they are asked for input once again
                else
                {
                    Console.WriteLine("");
                }

            } while (!isDouble);

            // Determine the number of doorways the user wishes to not paint
            do
            {
                Console.WriteLine("Enter the number of doorways that you wish not to paint");
                isInt = int.TryParse(Console.ReadLine(), out numOfDoorways);
                if (!isInt)
                {
                    Console.WriteLine("Please enter an integer value\n");
                }
                // If the user didn't enter a int, they are asked for input once again
                else
                {
                    Console.WriteLine("");
                }

            } while (!isInt);
            
            // Determine the cost of paint based on user input
            do
            {
                Console.WriteLine("Enter the cost of paint");
                isDouble = double.TryParse(Console.ReadLine(), out costOfPaint);
                if (!isDouble)
                {
                    Console.WriteLine("Please enter a decimal value\n");
                }
                // If the user didn't enter a double, they are asked for input once again
                else
                {
                    Console.WriteLine("");
                }

            } while (!isDouble);


            // Initilize a wall object
            // width: width of the wall
            // height: height of the wall
            // numOfDoorways: Number of doorways you wish to not paint 
            // 
            // return: Wall Object

            wall = new Wall(width, height, numOfDoorways);

            // Initilize a paint object
            // costOfPaint: cost of the paint
            //
            // return: Paint Object

            paint = new Paint(costOfPaint);

            // Determine the total area that needs to be painted
            double areaToPaint = wall.getWallArea() - wall.getAreaOfDoorways();

            // Calculate the number of gallons needed for this job

            double numOfGallons = paint.getNumOfGallons(areaToPaint);

            // Return the cost of the paint based on the number of galllons
            double costOfAllPaint = paint.getCostOfPaint(numOfGallons);

            // Convert the cost of paint to a readable format
            String costOfPaintInUSCurrency = costOfAllPaint.ToString("C", CultureInfo.CurrentCulture);

            // Format the gallon string to a more user-friendly format
            String gallonString = numOfGallons.ToString("0.##");

            // Output the number of gallons of paint needed for the job and how much it will cost them
            Console.WriteLine("I need {0} gallons of paint. That will cost me {1}.", gallonString, costOfPaintInUSCurrency);

            Console.Read();
        }
    }
}
