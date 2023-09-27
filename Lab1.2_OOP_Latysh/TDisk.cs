using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1_OOP_Latysh;


namespace Lab1._2_OOP_Latysh
{
    class TDisk
    {
        protected double radius;
        protected Point centre;

        public TDisk()
        {
            radius = 1;
            centre = new Point(0, 0);
        }
        public TDisk(double radius, double centreX, double centreY) 
        {
            this.radius = radius;
            centre = new Point(centreX, centreY);
        }
        public TDisk(double radius, Point centre) 
        {
            this.radius = radius;
            this.centre = centre;
        }
        public TDisk(TDisk disk)
        {
            this.radius = disk.radius;
            this.centre = disk.centre;
        }
        public override string ToString()
        {
            return $"Disk: Radius = {Radius}; Centre = [{centre.X};{centre.Y}]";
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Point Centre
        {
            get { return centre; }
            set { centre = value; }
        }
        public double Area()
        {
            return Math.PI*Math.Pow(Radius,2);
        }
        public bool IsPointInside(Point point)
        {
            if (Math.Pow(point.X - centre.X, 2) + Math.Pow(point.Y - centre.Y, 2) < Math.Pow(Radius, 2))
                return true;
            return false;
        }
        public bool IsPointInside(double x, double y)
        {
            if (Math.Pow(x - centre.X, 2) + Math.Pow(y - centre.Y, 2) < Math.Pow(Radius, 2))
                return true;
            return false;
        }
        public double MultiplyNumOnRadius(int num, double radius)
        {
            radius *= num;
            return radius;
        }
        public static TDisk operator +(TDisk disk, double num)
        {
            double radius = disk.radius;
            radius *= num;
            return new TDisk(radius, disk.centre);
        }
        public static TDisk operator +(double num, TDisk disk)
        {
            double radius = disk.radius;
            radius *= num;
            return new TDisk(radius, disk.centre);
        }
    }
}
