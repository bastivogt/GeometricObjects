using System;

namespace GeometricObjects
{
    abstract class Shape : Point
    {
        protected int _width;
        public virtual int Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }


        protected int _height;
        public virtual int Height
        {
            get 
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }

        protected static int _count = 0;
        public static int Count {
            get
            {
                return _count;
            }
        }


        // Constructors
        public Shape(int x, int y, int width, int height) : base(x, y)
        {
            this.Width = width;
            this.Height = height;
            _count ++;
            Console.WriteLine("Shape(x, y, widt, height)");
        }

        public Shape(int x, int y) : this(x, y, 0, 0)
        {
            Console.WriteLine("Shape(x, y)");
        }

        public Shape() : this(0, 0)
        {
            Console.WriteLine("Shape()");
        }


        public bool isBigger(Shape shape)
        {
            if(this.GetArea() > shape.GetArea())
            {
                return true;
            }
            return false;
        }


        public virtual void Size(int dWidth, int dHeight)
        {
            this.Width += dWidth;
            this.Height += dHeight;
        }

        public virtual void Resize(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }


        public abstract double GetArea ();

        public override string ToString()
        {
            return "Shape [X: " + this.X + ", Y: " + this.Y + ", Width: " + this.Width + ", Height: " + this.Height + "]";
        }



    }
}