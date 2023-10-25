using OtherShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAP_Assignment_7_1_PeerToPeer_Adapter
{
    /// <summary>
    /// Adapter design pattern for adapting a Rhombus into an IShape.
    /// </summary>
    internal class RhombusAdapter : IShape
    {
        private readonly Rhombus _rhombus;
        public string Type => "Rhombus";
        public double SizeArea => Area();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rhombus">Rhombus to be adapted to IShape</param>
        public RhombusAdapter(Rhombus rhombus)
        {
            _rhombus = rhombus;
        }

        /// <summary>
        /// Uses original Rhombus delegate AreaFormula to calculate the Area
        /// </summary>
        /// <returns>Area of Rhombus</returns>
        public double Area() => _rhombus.AreaFormula()(_rhombus);

        /// <summary>
        /// Uses original Rhombus PrintDescriptionToConsole method and redirects output to a MessageBox
        /// by using the OutputRedirector class
        /// </summary>
        public void PrintMe()
        {
            // Redirecting output to show as a MessageBox rather than Console.
            OutputRedirector outputRedirector = new OutputRedirector();
            // Changing the output of Console to that specified in OutputRedirector class ie MessageBox.Show().
            Console.SetOut(outputRedirector);
            _rhombus.PrintDescriptionToConsole();
        }
    }
}
