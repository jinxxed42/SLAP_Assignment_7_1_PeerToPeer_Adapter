using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SLAP_Assignment_7_1_PeerToPeer_Adapter
{
    internal class Circle : IShape
    {
        public double Diameter { get; init; } // Assignment demands a property, but since I only display the area 
                                              // in my DataGrid I would normally use a readonly field instead.

        public string Type => "Circle";
        public double SizeArea => Area();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="diameter">Diameter of the Circle</param>
        public Circle(double diameter)
        {
            Diameter = diameter;
        }

        /// <summary>
        /// Calculate area of the Circle
        /// </summary>
        /// <returns>Area of the Circle</returns>
        public double Area() => Math.PI * Math.Pow((Diameter/2), 2);

        /// <summary>
        /// Displays infomration about the Circle in a MessageBox
        /// </summary>
        public void PrintMe() => MessageBox.Show($"This is a circle with diameter {Diameter} and area {Area()}.");
    }
}
