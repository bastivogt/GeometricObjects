using System;

namespace GeometricObjects
{
    class Circle : Shape
    {
        protected int _radius = 0;
        public int Radius
        {
            get
            {
                return this._radius;
            }
            set
            {
                this._radius = value;
                this.Width = value * 2;
            }
        }

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
                this.Radius = Convert.ToInt32(value / 2);
            }
        }


        public override int Height 
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
                this._width = value;
                this.Radius = Convert.ToInt32(value / 2);
            }
        }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.Radius = radius;
        }
        
        public Circle(int x, int y) : this(x, y, 1)
        {

        }

        public Circle() : this(0, 0, 1)
        {

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