using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2_OOP_Latysh
{
    class TBall : TDisk
    {
        new protected Point3D centre;
        public TBall() : base()
        {
            centre = new Point3D(0, 0, 0);
        }
        public TBall(double radius, double centreX, double centreY, double centreZ)
        {
            this.radius = radius;
            centre = new Point3D(centreX, centreY, centreZ);
        }
        public TBall(double radius, Point3D centre)
        {
            this.radius = radius;
            this.centre = centre;
        }
        public TBall(TBall ball)
        {
            this.radius = ball.radius;
            this.centre = ball.centre;
        }
        public override string ToString()
        {
            return $"Ball: Radius = {Radius}; Centre = [{centre.X};{centre.Y};{centre.Z}]";
        }
        new public Point3D Centre
        {
            get { return centre; }
            set { centre = value; }
        }
        new public double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }
        public double Volume()
        {
            return (4 * Math.PI * Math.Pow(Radius, 3))/3.0;
        }
        public bool IsPointInside(Point3D point3D)
        {
            if (Math.Pow(point3D.X - centre.X, 2) + Math.Pow(point3D.Y - centre.Y, 2) + Math.Pow(point3D.Z - centre.Z, 2) < Math.Pow(Radius, 2))
                return true;
            return false;
        }
        public bool IsPointInside(double x, double y, double z)
        {
            if (Math.Pow(x - centre.X, 2) + Math.Pow(y - centre.Y, 2) + Math.Pow(z - centre.Z, 2) < Math.Pow(Radius, 2))
                return true;
            return false;
        }
        public static TBall operator +(TBall ball, double num) 
        {
            double radius = ball.radius;
            radius *= num;
            return new TBall(radius, ball.centre);
        }
        public static TBall operator +(double num, TBall ball)
        {
            double radius = ball.radius;
            radius *= num;
            return new TBall(radius, ball.centre);
        }
    }
}
