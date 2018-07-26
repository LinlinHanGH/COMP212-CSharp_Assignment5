using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenInt_Click(object sender, EventArgs e)
        {
            int Min = 0;
            int Max = 20;
            Random randNum = new Random();
            int[] intArray = Enumerable
                .Repeat(0, 5)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();
        }
    }
}
