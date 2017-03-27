using System;

namespace GeometricObjects
{
    class Square : Rectangle
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
            }
        }


        public Square(int x, int y, int width): base(x, y)
        {
            this.Width = width;
        }

        public Square(int x, int y) : this(x, y, 0)
        {

        }

        public Square(): this(0, 0)
        {

        }

        public override double GetArea()
        {
            return Math.Pow(this.Width, 2);
        }


        public void Size(int dWidth)
        {
            this.Width += dWidth;
        }

        public void Resize(int width)
        {
            this.Width = width;
        }

    }
}