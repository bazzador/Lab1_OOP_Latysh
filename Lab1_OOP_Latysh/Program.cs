using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP_Latysh
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = {6,12,18};
            double[] array1 = {2,4,-6};
            double[] array2 = {2,4,6};
            double[] array3 = { 10, 5, 3 };
            Line line1 = new Line(array);
            Line line2 = new Line(array1);
            Line line3 = new Line(array2);
            Line line4 = new Line(array3);
            int x;
            Point pointA = new Point(-3, 0);
            Point pointB = new Point(3, 4);
            Point pointC = new Point(10, 10);

            

            Exercise1 exercise = new Exercise1();
            do
            {
                Console.WriteLine("1. Дві лінії паралельні\n2. Дві лінії накладуються\n3. Дві лінії пересікаються\n4.Одна точка належить прямій, інша ні"); 
                //
                //
                //
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Point point1 = exercise.TwoLines_Cross(line1, line2); // паралельні
                        Console.WriteLine(point1);
                        break;
                    case 2:
                        Point point2 = exercise.TwoLines_Cross(line1, line3); // накладуються
                        Console.WriteLine(point2);
                        break;
                    case 3:
                        Point point3 = exercise.TwoLines_Cross(line2, line4); // перетин
                        Console.WriteLine(point3);  
                        break;
                    case 4:
                        exercise.isPoint_OnLine(pointA, line1);
                        exercise.isPoint_OnLine(pointB, line1);
                        break;
                }
            } while (x != 0);



        }
    }
}
