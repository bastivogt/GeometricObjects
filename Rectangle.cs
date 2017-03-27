using System;

namespace GeometricObjects
{
    class Rectangle : Shape
    {


        public Rectangle(int x, int y, int width, int height) : base(x, y, width, height)
        {

        }

        public Rectangle(int x, int y) : this(x, y, 0, 0)
        {

        }

        public Rectangle() : base(0, 0)
        {

        }

        public override double GetArea()
        {
            return this.Width * this.Height;
        }



        public override string ToString()
        {
            return "Rectangle [X: " + this.X + ", Y: " + this.Y + ", Width: " + this.Width + ", Height: " + this.Height + "]";
        }
    }
}