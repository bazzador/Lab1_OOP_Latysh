using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP_Latysh
{
    public class Point
    {
        protected double x_;
        protected double y_;
        public Point(double x, double y)
        {
            this.x_ = x;
            this.y_ = y;
        }
        public double X 
        {
            get { return x_; }
            set { x_ = value;}
        }
        public double Y
        {
            get { return y_; }
            set { y_ = value; }
        }
        public override string ToString()
        {
            return $"Point: [{this.X};{this.Y}]";
        }
    }
}
