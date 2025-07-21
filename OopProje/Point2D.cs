//********************************************************************************************************
//********************************************************************************************************
//******
//******         STUDENT NAME/SURMANE :ÖMER MEMİŞ
//******         STUDENT NUMBER : B221202069
//******
//********************************************************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectOOP
{
    internal class Point2D
    {
        public double x { get; set; }               // Property for x coordinate
        public double y { get; set; }                // Property for y coordinate
        double r;
        double theta;

        static Random random1 = new Random();

        public Point2D()        //constractor to initialize x and y coordinates with random values
        {
            //3 birim uzaklıkta olması icin merkezle olan uzaklıklarını hesapladım ve yaklasık olarak bu değerleri verdim
            x = random1.Next(232, 292);
            y = random1.Next(195, 255);

        }

        public Point2D(double x, double y)   //constructor to initialize x and y coordinates
        {
            this.x = x;
            this.y = y;
        }

        public void printCoordinates()
        { 
            Console.WriteLine($"2D Point Coordinates (P(x,Y)) : P({x}, {y})");
        }

        public void calculatePolarCoordinates()         //calculate r and theta to find polar coordinates
        {
            r = Math.Sqrt((x * x) + (y * y));
            theta = Math.Atan2(y, x);
        }

        public void calculateCartesianCoordinates()     //calculate x and y to find cartesian coordinates
        {

            x = Math.Cos(theta) * r;
            y = Math.Sin(theta) * r;

        }

        public void printPolarCoordinates()
        {
            Console.WriteLine($"Polar Coordinates (P(r, theta)) : P({r}, {theta})");
        }
               
    }
}
