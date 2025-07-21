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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace projectOOP
{
    internal class ColorRGB
    {
        public int Red { get; set; }        // Property for Red color
        public int Green { get; set; }      // Property for Green color
        public int Blue { get; set; }       // Property for Blue color

        static Random random2 = new Random();

        public ColorRGB()                   //default constructor
        {
            Red = 0;
            Green = 0;
            Blue = 0;
        }

        public ColorRGB(int red, int green, int blue)           //constructor to initialize RGB values
        {
             if(red >= 0 && red <= 255) Red=red;
             if(green >= 0 && green <= 255) Green=green;
             if(blue >= 0 && blue <= 255) Blue=blue;

        }

        public ColorRGB(bool randomize)             //constructor to initialize RGB values with random values
        {
            if(randomize)
            {
                Red = random2.Next(0, 255);
                Green = random2.Next(0, 255);
                Blue = random2.Next(0, 255);
            }
            else
            {
                Red = 0;
                Green = 0;
                Blue = 0;
            }
        }
    }
}