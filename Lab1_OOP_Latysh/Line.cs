using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP_Latysh
{
    class Line
    {
        // Ax+By+C=0
        protected double[] line;
        public Line(params double[] array)
        {
            this.line = new double[3];
            for (int i = 0; i < 3; i++)
                line[i] = array[i];
        }
        public int Length
        {
            get { return line.Length; }
        }
        public double this[int i]
        {
            get
            {
                if (i >= 0 && i < 3)
                    return line[i];
                else return 0;
            }
            set
            {
                if(i>=0 && i < 3)
                {
                    line[i] = value;
                }
            }
        }
        public void View()
        {
            Console.WriteLine($"Пряма: {this.line[0]}x+({this.line[1]})y+({this.line[2]})");
        }
    }
}
