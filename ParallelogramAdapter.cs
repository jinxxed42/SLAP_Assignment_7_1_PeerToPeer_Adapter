using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SLAP_Assignment_7_1_PeerToPeer_Adapter
{
    /// <summary>
    /// Adapter design pattern for adapting a Parallelogram into an IShape.
    /// </summary>
    internal class ParallelogramAdapter : IShape
    {
        private readonly Parallelogram _parallelogram;
        public string Type => "Parallelogram";
        public double SizeArea => Area();

        public ParallelogramAdapter(Parallelogram parallelogram)
        {
            _parallelogram = parallelogram;
        }

        public double Area() => _parallelogram.GetArea();        

        public void PrintMe() => MessageBox.Show(_parallelogram.GetDescription());
    }
}
