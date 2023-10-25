using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OtherShapes;

namespace SLAP_Assignment_7_1_PeerToPeer_Adapter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<IShape> shapes { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            shapes = new()
            {
                new Circle(4.0),
                new Rectangle(1.5, 2.5),
                new TriangleAdapter(new Triangle(2.5, 3.5, 4.5)),
                new RhombusAdapter(new Rhombus(3.2, 2.2)),
                new ParallelogramAdapter(new Parallelogram(5.3, 3.1))
            };

            DataGrid_Figures.ItemsSource = shapes;          
        }

        /// <summary>
        /// Method for adding an IShape to the List of shapes.
        /// </summary>
        /// <param name="shape">An object implementing IShape</param>
        public void AddFigure(IShape shape)
        {
            shapes.Add(shape);

            // Since we are using a List we need to set the ItemsSource to null
            // and then the List again to force an update.
            // In general an ObservableCollection would be smarter for this, 
            // but the assignment says use a List.
            DataGrid_Figures.ItemsSource = null;
            DataGrid_Figures.ItemsSource = shapes;
        }

        /// <summary>
        /// Eventhandler for clicks on the Create button.
        /// </summary>
        /// <param name="sender">Sender-object</param>
        /// <param name="e">EventArgs</param>
        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            if (Circle.IsChecked == true)
            {
                CircleInput ci = new CircleInput(this);
                ci.Left = 200;
                ci.Top = 200;
                ci.ShowDialog();
            }
            else if (Parallelogram.IsChecked == true)
            {
                ParallelogramInput pi = new ParallelogramInput(this);
                pi.Left = 200;
                pi.Top = 200;
                pi.ShowDialog();
            }
            else if (Rectangle.IsChecked == true)
            {
                RectangleInput ri = new RectangleInput(this);
                ri.Left = 200;
                ri.Top = 200;
                ri.ShowDialog();
            }
            else if (Rhombus.IsChecked == true)
            {
                RhombusInput ri = new RhombusInput(this);
                ri.Left = 200;
                ri.Top = 200;
                ri.ShowDialog();
            }
            else if (Triangle.IsChecked == true)
            {
                TriangleInput ti = new TriangleInput(this);
                ti.Left = 200;
                ti.Top = 200;
                ti.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please make a selection, before clicking create.");
            }
        }

        /// <summary>
        /// Eventhandler for clicks on the Describe selected button.
        /// </summary>
        /// <param name="sender">Sender-object</param>
        /// <param name="e">EventArgs</param>
        private void Button_Describe_Click(object sender, RoutedEventArgs e)
        {
            // Find the selected item in the DataGrid
            IShape selectedShape = (IShape)DataGrid_Figures.SelectedItem;
            if (selectedShape == null) MessageBox.Show("You should select an item to describe.");
            else selectedShape.PrintMe();
        }

        /// <summary>
        /// Eventhandler for clicks on the Delete selected button.
        /// </summary>
        /// <param name="sender">Sender-object</param>
        /// <param name="e">EventArgs</param>
        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            // Find the selected item in the DataGrid.
            IShape selectedShape = (IShape)DataGrid_Figures.SelectedItem;
            if (selectedShape == null) MessageBox.Show("You should select an item to delete.");
            else 
            { 
                shapes.Remove(selectedShape);
                // Úpdate the DataGrid.
                DataGrid_Figures.ItemsSource = null;
                DataGrid_Figures.ItemsSource = shapes;
            }
        }
    }
}
