using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SLAP_Assignment_7_1_PeerToPeer_Adapter
{
    /// <summary>
    /// For redirecting Console output to a MessageBox.
    /// </summary>
    internal class OutputRedirector : TextWriter
    {
        public override Encoding Encoding => Encoding.UTF8;

        /// <summary>
        /// Overriding the default Write to display as a MessageBox instead.
        /// </summary>
        /// <param name="value">string to be displayed</param>
        public override void Write(string? value)
        {
            if (!string.IsNullOrWhiteSpace(value)) MessageBox.Show(value);
        }
    }
}
