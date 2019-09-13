using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Square;

namespace TestSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calculate calc = new calculate();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
//                 double i = calc.Area(2.0);
                double i = calc.Square();
//                 double i = calc.CircleArea(2.0);
//                 double i = calc.TriangleArea(6.0, 4.0, 8.0);

                txtResult.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
