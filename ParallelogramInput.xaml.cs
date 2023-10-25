using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SLAP_Assignment_7_1_PeerToPeer_Adapter
{
    /// <summary>
    /// Interaction logic for ParallelogramInput.xaml
    /// </summary>
    public partial class ParallelogramInput : Window
    {
        MainWindow window; // We need access to the MainWindow to use the AddFigure method.

        public ParallelogramInput(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
        }

        /// <summary>
        /// Eventhandler for clicks on the Create button.
        /// </summary>
        /// <param name="sender">Sender-object</param>
        /// <param name="e">EventArgs</param>
        private void Button_ParallelogramInput_Create_Click(object sender, RoutedEventArgs e)
        {
            // Checking for valid input values.
            if (double.TryParse(Parallelogram_Length.Text, out double length)
                && double.TryParse(Parallelogram_Height.Text, out double height)
                && length > 0 && height > 0)
            {
                window.AddFigure(new ParallelogramAdapter(new Parallelogram(length, height)));
                this.Close();
            }
            else MessageBox.Show("You must specify a valid double values above 0 for length and height!");
        }

        /// <summary>
        /// Eventhandler for clicks on the Cancel button.
        /// </summary>
        /// <param name="sender">Sender-object</param>
        /// <param name="e">EventArgs</param>
        private void Button_ParallelogramInput_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
