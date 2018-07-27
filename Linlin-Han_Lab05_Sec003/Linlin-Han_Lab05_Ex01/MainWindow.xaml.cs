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
using System.Collections;

namespace Linlin_Han_Lab05_Ex01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int[] intArray = new int[100];
        double[] doubleArray = new double[50];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenIntArray_Click(object sender, RoutedEventArgs e)
        {
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
            for (int i = 0; i < doubleArray.Length; ++i)
            { doubleArray[i] = rnd.NextDouble() * (100 - 0) + 0; }

            string displayArray = "";

            foreach (var item in doubleArray)
            {
                displayArray += item.ToString("0.00") + ", ";
            }

            txtDisplay.Text = displayArray;

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchfor = txtGetNum.Text.ToString();
            int num1 =Convert.ToInt32( searchfor);
            int count = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if(CompareNumbers(num1, intArray[i]) == true)
                {
                     result.Text += i.ToString()+",";
                    count++;
                }

            }
            if (count== 0)
            {
                result.Text = "-1";
            }

        }

        private static bool CompareNumbers<T>(T num1, T num2) where T : IComparable<T>
        {
            Boolean result=false;

            if (num1.CompareTo(num2) == 0)
            {
                result = true;
            }

            else if (num1.CompareTo(num2) != 0)
            {
                result = false;
            }

            return result; // return largest object
        }

       
    }
}
