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
        string displayArray = "";
        string arrayType = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenIntArray_Click(object sender, RoutedEventArgs e)
        {
            arrayType = "intArray";
            result.Text = "";
            txtGetNum.Text = "";
            for (int i = 0; i < intArray.Length; ++i)
            { intArray[i] = rnd.Next(100); }
                
            displayArray="";

            foreach (var item in intArray)
            {
                displayArray += item + ", ";
            }

            txtDisplay.Text = displayArray;
            
        }

        private void btnGenDoubleArray_Click(object sender, RoutedEventArgs e)
        {
            arrayType = "doubleArray";
            result.Text = "";
            txtGetNum.Text = "";
            for (int i = 0; i < doubleArray.Length; ++i)
            { doubleArray[i] = Math.Round( rnd.NextDouble() * (100 - 0) + 0,2); }
            displayArray = "";
            foreach (var item in doubleArray)
            {
                displayArray += item + ", ";
            }

            txtDisplay.Text = displayArray;
            

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchfor = txtGetNum.Text.ToString();
            string strResult = "";
            if (arrayType == "intArray") {
                int searchForInt=0;
                try
                {
                    searchForInt = Convert.ToInt32(searchfor);
                }
                catch {
                    result.Text = "error";
                }
                
                int count = 0;
                for (int i = 0; i < intArray.Length; i++)
                {
                    if (CompareNumbers(searchForInt, intArray[i]) == true)
                    {
                        strResult += i.ToString() + ",";
                        count++;
                    }

                }
                result.Text = strResult;

                if (count == 0)
                {
                    result.Text = "-1";
                }
            }
            if (arrayType == "doubleArray")
            {
                double searchForDouble = 0;

                try {
                    searchForDouble = Convert.ToDouble(searchfor);
                }
                catch
                {
                    result.Text = "error";
                }
                
                int count = 0;
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    if (CompareNumbers(searchForDouble, doubleArray[i]) == true)
                    {
                        strResult += i.ToString() + ",";
                        count++;
                    }

                }
                result.Text = strResult;
                if (count == 0)
                {
                    result.Text = "-1";
                }
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
