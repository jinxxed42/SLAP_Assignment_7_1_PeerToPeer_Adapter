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
    /// Interaction logic for CircleInput.xaml
    /// </summary>
    public partial class CircleInput : Window
    {
        MainWindow window; // We need access to the MainWindow to use the AddFigure method.

        public CircleInput(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
        }

        /// <summary>
        /// Eventhandler for clicks on the Create button.
        /// </summary>
        /// <param name="sender">Sender-object</param>
        /// <param name="e">EventArgs</param>
        private void Button_CircleInput_Create_Click(object sender, RoutedEventArgs e)
        {
            // Checking for valid input values.
            if (double.TryParse(Circle_Diameter.Text, out double diameter) && diameter > 0)
            {
                window.AddFigure(new Circle(diameter));
                this.Close();
            }
            else MessageBox.Show("You must specify a valid double value above 0!");
        }

        /// <summary>
        /// Eventhandler for clicks on the Cancel button.
        /// </summary>
        /// <param name="sender">Sender-object</param>
        /// <param name="e">EventArgs</param>
        private void Button_CircleInput_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
