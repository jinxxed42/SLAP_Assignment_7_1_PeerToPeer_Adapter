using OtherShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SLAP_Assignment_7_1_PeerToPeer_Adapter
{
    /// <summary>
    /// Adapter design pattern for adapting a Triangle into an IShape.
    /// </summary>
    internal class TriangleAdapter : IShape
    {
        private readonly Triangle _triangle;
        public string Type => "Triangle";
        public double SizeArea => Area();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="triangle">Triangle to be adapted to IShape</param>
        public TriangleAdapter(Triangle triangle)
        {
            _triangle = triangle;
        }

        /// <summary>
        /// Calculates the area of the adapted Triangle using the original Triangle class's CalculateArea method.
        /// </summary>
        /// <returns>Area of Triangle</returns>
        public double Area() => _triangle.CalculateArea();

        /// <summary>
        /// Outputs a description of the adapted Triangle using the original Triangle class's GetDescription
        /// method and shows it in a MessageBox.
        /// </summary>
        public void PrintMe() => MessageBox.Show(_triangle.GetDescription());
    }
}
