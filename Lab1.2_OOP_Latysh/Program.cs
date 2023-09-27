using Lab1_OOP_Latysh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1._2_OOP_Latysh
{
    class Program
    {
        static void Main(string[] args)
        {

            Point point = new Point(10, 10);
            //TDisk disk = new TDisk();           +++
            //TDisk disk = new TDisk(10, 3, 4);   +++
            //TDisk disk = new TDisk(10, point);  +++

            //Console.WriteLine(disk.ToString()); +++
            //TBall ball1 = new TBall(10, 0, 0, 0);
            //Console.WriteLine(ball1.ToString());

            //Console.WriteLine(ball1.Volume());
            //disk1.MultiplyNumOnRadius(ref disk1.Radius, 5); //
            //Console.WriteLine(disk1.IsPointInDisk(2,3));         +++
            //Console.WriteLine(disk1.IsPointInDisk(point));
            TDisk disk1 = new TDisk(5, 0, 0);
            TBall ball1 = new TBall(10, 0, 0, 0);
            Point point1 = new Point(1,1);
            Point point2 = new Point(6, 6);
            int x;
            do
            {
                Console.WriteLine("1.Площа круга\n2. Перша точка належить кругу, друга ні\n3. Об'єм куба");
                //
                //
                //
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine(disk1.Area());
                        break;
                    case 2:
                        Console.WriteLine(disk1.IsPointInside(point1));
                        Console.WriteLine(disk1.IsPointInside(point2)); break;
                    case 3:
                        Console.WriteLine(ball1.Volume());
                        break;
                    case 4:
                        break;
                }
            } while (x != 0);
        }
    }
}
