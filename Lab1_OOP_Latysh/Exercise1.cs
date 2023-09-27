using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP_Latysh
{
    class Exercise1
    {
        public Point TwoLines_Cross(Line line1, Line line2)
        {
            if ((line1[0] == line2[0] && line1[1] == line2[1] && line1[2] == line2[2]) || (Math.Abs(line1[0] / line2[0] - line1[1] / line2[1])<=Double.Epsilon && Math.Abs(line1[1]/line2[1]-line1[2] / line2[2])<=Double.Epsilon))
                throw new ArgumentException("Точки перетину немає, рівняння накладаються одна на одну");
            if(line1[0] == line2[0] && line1[1]==line2[1] && line1[2] != line2[2])
                throw new ArgumentException("Точки перетину немає, рівняння паралельні");
            
            double y = (line2[0] * line1[2] - line1[0] * line2[2]) / (line1[0] * line2[1] - line2[0] * line1[1]);
            double x = (-line1[1] * y - line1[2]) / line1[0];
            return new Point (x,y);
        }
        public void isPoint_OnLine(Point point, Line line)
        {
            if (line[0] * point.X + line[1] * point.Y + line[2] == 0)
                Console.WriteLine("Точка належить прямій.");
            else Console.WriteLine("Точка НЕ належить прямій.");
        }
    }
}
//double y = (line2.A * line1.C - line1.A * line2.C) / (line1.A * line2.B - line2.A * line1.B);
//double x = (-line1.B * y - line1.C) / line1.A;