using System;

namespace GeometricObjects
{
    class Point 
    {
        public int X {get; set;} = 0;
        public int Y {get; set;} = 0;

        protected static int _count = 0;
        public static int Count {
            get
            {
                return _count;
            }
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
            _count += 1;
            Console.WriteLine("Point(x, y)");
        }

        public Point() : this(0, 0) 
        {
            Console.WriteLine("Point()");
        }


        public virtual void Move(int dx, int dy)
        {
            this.X += dx;
            this.Y += dy;
        }

        public virtual void MoveTo(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }



        public override string ToString()
        {
            return "Point [X: " + this.X + ", Y: " + this.Y + "]";
        }

    }
}