using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1_OOP_Latysh;


namespace Lab1._2_OOP_Latysh
{
    class Point3D:Point
    {
        protected double z_;
        public Point3D(double x, double y, double z) : base(x, y)
        {
            this.z_ = z;
        }
        public double Z
        {
            get { return z_; }
            set { z_ = value; }
        }

    }
}
