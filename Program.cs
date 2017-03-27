using System;

namespace GeometricObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] objs = new Square[3];
            objs[0] = new Square(10, 10, 30);
            objs[1] = new Square(20, 20);
            objs[2] = new Square();

            foreach(Rectangle o in objs)
            {
                Console.WriteLine(o);
            }

            objs[1].Size(33);

            Console.WriteLine(objs[0].isBigger(objs[1]));

            Console.WriteLine(Point.Count);

            foreach(Rectangle o in objs)
            {
                Console.WriteLine(o);
            }

        }
    }
}
