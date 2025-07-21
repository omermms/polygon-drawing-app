//********************************************************************************************************
//********************************************************************************************************
//******
//******         STUDENT NAME/SURMANE :ÖMER MEMİŞ
//******         STUDENT NUMBER : B221202069
//******
//********************************************************************************************************


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectOOP
{
    public partial class Form1 : Form
    {

        private List<Point> Vertices = new List<Point>();
        private Polygon polygon;

        public Form1()
        {
            InitializeComponent();
            // Set the initial center point of the polygon to the center of the pictureBox (in pixels)
            Point2D center = new Point2D(pictureBox.Width / 2, pictureBox.Height / 2);

            // Set the initial length (scaled to 10) and number of sides of the polygon according to the default value
            int firstLenght = 4 * 10;
            int firstNumberOfEdges = 5;
            polygon = new Polygon(center, firstLenght, firstNumberOfEdges);         // Create the initial polygon with the specified center, length, and number of edges
            polygon.calculateEdgeCoordinates();         // Calculate the coordinates of the polygon's vertices
            printCoordinates();

            // Set the initial values of the textboxes for center coordinates (convert from pixel to user coordinate system)
            txtx.Text = ((polygon.center.x - pictureBox.Width / 2) / 10).ToString();
            txty.Text = (((polygon.center.y - pictureBox.Height / 2) / 10) * (-1)).ToString();

            // If the calculated y value is -0, set it to "0" for display purposes
            if (((polygon.center.y - pictureBox.Height / 2) / 10) * (-1) == -0)
            {
                txty.Text = "0";
            }

            // Set the initial values for length and number of edges textboxes (convert from pixel to user coordinate system)
            txtlength.Text = (polygon.length / 10).ToString();
            txtedge.Text = polygon.numberOfEdges.ToString();

            // Set the color trackbars to match the polygon's color
            trackBarRed.Value = polygon.color.Red;
            trackBarGreen.Value = polygon.color.Green;
            trackBarBlue.Value = polygon.color.Blue;

            txtangle.Text = "30";       // Set the initial angle textbox value to 30 degrees

            pictureBox.Invalidate();
            pictureBox.Paint += pictureBox_Paint;   // Attach the Paint event handler to the pictureBox

        }

        private void button_draw(object sender, EventArgs e)
        {
            // Get the RGB values from the color trackbars
            int r = trackBarRed.Value;
            int g = trackBarGreen.Value;
            int b = trackBarBlue.Value;
            ColorRGB myColor = new ColorRGB(r, g, b);

            // Calculate the center coordinates in pixels from the user input (convert from user coordinate system)
            double centerX = Convert.ToDouble(txtx.Text)*10 + pictureBox.Width / 2;
            double centerY = (Convert.ToDouble(txty.Text)*10 - pictureBox.Height / 2) * (-1);

            // Get the length and number of edges from the textboxes (convert length to pixels)
            int length = Convert.ToInt32(txtlength.Text)*10;
            int numberOfEdges = Convert.ToInt32(txtedge.Text);

            //If the desired number of sides is not entered, a warning is given with a messageBox.
            if (!(numberOfEdges >= 3 && numberOfEdges <= 10))
            {
                MessageBox.Show("Number of edges must be between 3 and 10");
                return;
            }

            // If the length is not entered in the desired length, a warning is given with a messageBox.
            if (!(length >= 30 && length <= 90))
            {
                MessageBox.Show("Length must be between 3 and 9");
                return;
            }

            // Create a new polygon with the specified parameters
            Point2D center1 = new Point2D(centerX, centerY);
            polygon = new Polygon(center1, length, numberOfEdges) { color = myColor };
            polygon.calculateEdgeCoordinates();         // Calculate the coordinates of the polygon's vertices
            printCoordinates();
            pictureBox.Invalidate();      // Redraw the picture box to display the new polygon
        }

        private void rotate_Click(object sender, EventArgs e)
        {   
            double angle = Convert.ToDouble(txtangle.Text);              // Get the angle value entered by the user from the textbox
            bool isCounterClockwise = radioButtonClockwise.Checked;         // Determine the rotation direction (true if counterclockwise, false if clockwise)

            polygon.RotatePolygon(angle, isCounterClockwise);           // Rotate the polygon by the specified angle and direction
            printCoordinates();
            pictureBox.Invalidate();                // Redraw the picture box to display the rotated polygon
            
        }
        private void reset_Click(object sender, EventArgs e)
        {
            polygon = new Polygon();
            polygon.calculateEdgeCoordinates();
            printCoordinates();
            //Due to center point x and y coordinates are divided by 10 The coordinates formed are not integers.
            txtx.Text= ((polygon.center.x- pictureBox.Width / 2) /10).ToString();           // Update the x textbox (convert from pixel to user coordinate system)
            txty.Text = (((polygon.center.y - pictureBox.Height / 2) / 10) * (-1)).ToString();      // Update the y textbox (convert from pixel to user coordinate system)
             // If the calculated y value is -0, set it to "0" for display purposes
            if (((polygon.center.y - pictureBox.Height / 2) / 10) * (-1) == -0)
            {
                txty.Text = "0";
            }
            txtlength.Text = (polygon.length/10).ToString();            // Update the length textbox (convert from pixel to user coordinate system)
            txtedge.Text = polygon.numberOfEdges.ToString();            // Update the number of edges textbox
            // Update the color trackbars with the polygon's color values
            trackBarRed.Value = polygon.color.Red;
            trackBarGreen.Value = polygon.color.Green;
            trackBarBlue.Value = polygon.color.Blue;
            txtangle.Text = "0";        //reset the angle textbox to 0
            pictureBox.Invalidate();      // Redraw the picture box to show the reset polygon

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)      // A function that draws the polygon on the picture box
        {
            // Create an array to hold the vertices of the polygon as PointF objects
            PointF[] points = new PointF[polygon.Vertices.Count];

            // Convert each vertex from Point2D to PointF for drawing
            for (int i = 0; i < polygon.Vertices.Count; i++)
            {
                points[i] = new PointF((float)polygon.Vertices[i].x, (float)polygon.Vertices[i].y);
            }
            // Create a pen with the polygon's color and a width of 1 pixel
            using (Pen pen = new Pen(Color.FromArgb(polygon.color.Red, polygon.color.Green, polygon.color.Blue), 1))
            {
                // Draw the polygon on the PictureBox using the specified pen and points
                e.Graphics.DrawPolygon(pen, points);
            }
        }

        void printCoordinates()       // A function that prints the coordinates of a polygon to a listbox
        {          
            listBoxEdge.Items.Clear();
            for (int i = 0; i < polygon.Vertices.Count; i++)
            {
                listBoxEdge.Items.Add($"Edge {i + 1}: ({Math.Round((polygon.Vertices[i].x - pictureBox.Width / 2)/10, 2)} ; " +
                    $"{Math.Round(((polygon.Vertices[i].y - pictureBox.Height / 2) / 10) * (-1), 2)})");
            }
        }            
    }
}
