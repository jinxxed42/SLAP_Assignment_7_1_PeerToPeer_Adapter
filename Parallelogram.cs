using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAP_Assignment_7_1_PeerToPeer_Adapter
{
    internal class Parallelogram
    {
        double _length;
        double _height;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="length">Length of Parallelogram</param>
        /// <param name="height">Height of Parallelogram</param>
        public Parallelogram(double length, double height)
        {
            _length = length;
            _height = height;
        }

        /// <summary>
        /// Calculate area of the Parallelogram
        /// </summary>
        /// <returns>Area of Parallelogram</returns>
        public double GetArea() => _length * _height;

        /// <summary>
        /// Returns information about the Parallelogram
        /// </summary>
        /// <returns>Description of the Parallelogram</returns>
        public string GetDescription() => $"This is a parallelogram with length {_length} and height {_height} for a total area of {GetArea()}.";
    }
}
