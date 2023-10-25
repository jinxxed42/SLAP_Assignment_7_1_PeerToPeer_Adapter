using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SLAP_Assignment_7_1_PeerToPeer_Adapter
{
    internal class Rectangle : IShape
    {
        public double Width { get; init; } // Assignment demands a property, but since I only display the area 
                                           // in my DataGrid I would normally use a readonly field instead.
        public double Height { get; init; } // Assignment demands a property, but since I only display the area 
                                            // in my DataGrid I would normally use a readonly field instead.

        public string Type => "Rectangle";
        public double SizeArea => Area();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="width">Width of the Rectangle</param>
        /// <param name="height">Height of the Rectangle</param>
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Calculate the area of the Rectangle
        /// </summary>
        /// <returns>Area of Rectangle</returns>
        public double Area() => Width * Height;

        /// <summary>
        /// Displays infomration about the Rectangle in a MessageBox
        /// </summary>
        public void PrintMe() => MessageBox.Show($"This is a rectangle with width {Width}, height {Height} and area {Area()}.");        
    }
}
