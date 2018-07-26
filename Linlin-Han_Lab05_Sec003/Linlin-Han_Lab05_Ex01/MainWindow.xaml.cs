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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Linlin_Han_Lab05_Ex01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenIntArray_Click(object sender, RoutedEventArgs e)
        {
            int[] intArray = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < intArray.Length; ++i)
            { intArray[i] = rnd.Next(100); }
                
            string displayArray="";

            foreach (var item in intArray)
            {
                displayArray += item + ", ";
            }

            txtDisplay.Text = displayArray;
        }

        private void btnGenDoubleArray_Click(object sender, RoutedEventArgs e)
        {
            double[] doubleArray = new double[50];
            Random rnd = new Random();
            for (int i = 0; i < doubleArray.Length; ++i)
            { doubleArray[i] = rnd.NextDouble() * (100 - 0) + 0; }

            string displayArray = "";

            foreach (var item in doubleArray)
            {
                displayArray += item.ToString("0.00") + ", ";
            }

            txtDisplay.Text = displayArray;

        }
    }
}
