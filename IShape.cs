using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAP_Assignment_7_1_PeerToPeer_Adapter
{
    public interface IShape
    {
        public string Type { get; }
        public double SizeArea { get; }

        public double Area();
        public void PrintMe();

    }
}
