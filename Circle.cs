using System;

namespace GeometricObjects
{

    class Circle : Shape
    {

        public override int Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
                this._height = value;
                this._radius = Convert.ToInt32(value / 2);
            }
        }

        public override int Height
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
                this._height = value;
                this._radius = Convert.ToInt32(value / 2);
            }
        }
        protected int _radius;
        public int Radius 
        {
            get
            {
                return this._radius;
            }
            set
            {
                this._radius = value;
                this._width = value * 2;
                this._height = value * 2;
                
            }
        }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.Radius = radius;
            Console.WriteLine("Circle(x, y, radius)");
        }

        public Circle(int x, int y) : this(x, y, 1)
        {
            Console.WriteLine("Circle(x, y)");
        }

        public Circle() : this(0, 0, 1)
        {
            Console.WriteLine("Circle()");
        }


        public override double GetArea()
        {
            return Math.Pow(this.Radius, 2) * Math.PI;
        }

        public override double GetSize()
        {
            return 2 * Math.PI * this.Radius;
        }


        public override string ToString()
        {
            return "Circle [X: " + this.X + ", Y: " + this.Y + ", Width: " + this.Width + ", Height: " + this.Height + ", Radius: " + this.Radius + "]";
        }

    }
}