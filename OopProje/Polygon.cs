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
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace projectOOP
{
    internal class Polygon
    {
        public Point2D center { get; set; }         // Property for center point
        public int length { get; set; }             // Property for length of the polygon
        public int numberOfEdges { get; set; }      // property for number of edges
        public ColorRGB color { get; set; }         // Property for color of the polygon
        public List<Point2D> Vertices { get; set; }     // Property for vertices of the polygon

        public Polygon()        //default constructor
        {
            Random rand = new Random();
            center = new Point2D();
            length = rand.Next(3, 9)*10;
            numberOfEdges = rand.Next(3, 10);
            color = new ColorRGB(true);
            Vertices = new List<Point2D>();
        }

        public Polygon( Point2D center, int length, int numberOfEdges)      //constructor to initialize center, length and number of edges
        {
            this.center = center;
            this.length = length;
            this.numberOfEdges = numberOfEdges;    
            color = new ColorRGB();
            Vertices = new List<Point2D>();
        }

        public void calculateEdgeCoordinates()          //calculate the coordinates of the edges of the polygon
        {
            Vertices.Clear();
            Random rand = new Random();
            
            double angle = rand.Next(0,360) ;               // Random starting angle for the first vertex
            double radius = length / (2 * Math.Sin(Math.PI / numberOfEdges));               // Calculate the radius of the circumscribed circle
            double angleStep = 360.0 / numberOfEdges;   // Angle step between each vertex

            for (int i = 0; i < numberOfEdges; i++)
            {
                double Rangle = (angle +(i*angleStep))*(Math.PI/180);
                double x = center.x + radius * Math.Cos(Rangle);
                double y = center.y + radius * Math.Sin(Rangle);
                Vertices.Add(new Point2D(x, y));            //find the next points and add them to the list
            }
        }

        public void RotatePolygon(double angleDegrees, bool isCounterClockwise)         // Rotate the polygon by a specified angle
        {
            if (Vertices == null || Vertices.Count == 0)
                return;

            // Convert angle to radians and set direction
            double angleRadians = -angleDegrees * Math.PI / 180;        
            if (!isCounterClockwise)
                angleRadians = -angleRadians;

            List<Point2D> rotatedVertices = new List<Point2D>();

            foreach (var vertex in Vertices)
            {
                //find the distance between the center and the point
                double dx = vertex.x - center.x;
                double dy = vertex.y - center.y;

                //rotate the point around the center
                double rotatedX = dx * Math.Cos(angleRadians) - dy * Math.Sin(angleRadians);
                double rotatedY = dx * Math.Sin(angleRadians) + dy * Math.Cos(angleRadians);

                rotatedVertices.Add(new Point2D( center.x + rotatedX, center.y + rotatedY ));         // Add the rotated vertex to the list

            }
            Vertices = rotatedVertices;
        }
    }
}
