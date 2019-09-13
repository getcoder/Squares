using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






using System.Windows.Forms;





namespace Square
{
    public class calculate
    {
        public double CircleSquare(double r)
        {
            return Math.PI * r * r;
        }

        public double TriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double Square(params double[] values)
        {
            int arguments = values.Length;

            if (arguments > 0)
            {
                int i = 0;
                do
                {
                    if (values[i] == 0)
                    {
                        MessageBox.Show("Arguments can't be '0'");
                        return -1;
                    }
                    i++;
                }
                while (i < arguments);
            }
            else
            {
                MessageBox.Show("No arguments");
                return -1;
            }

            if (arguments == 1)
            {
                return CircleSquare(values[0]);
            }
            else if (arguments == 3)
            {
                double a = values[0];
                double b = values[1];
                double c = values[2];

                if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a))
                {
                    MessageBox.Show("Triangle is right");
                }
                return TriangleSquare(a, b, c);
            }
            else
            {
                MessageBox.Show("No suitable formulas");
                return -1;
            }
        }

    }
}
