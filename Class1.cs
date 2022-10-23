using Newtonsoft.Json;

namespace Övningar
{
    internal class Class1
    {
        public void Go()
        {
            List<Shape> shapes = new List<Shape>();
            var p = new Point(1, 1);
            Circle s1 = new Circle(p, 4);
            shapes.Add(s1);
            Circle s2 = new Circle(p, 2);
            shapes.Add(s2);
            Rectangle r1 = new Rectangle(p, 3, 6);
            shapes.Add(r1);
            foreach (Shape s in shapes)
                s.Draw();

        }

    }
    public class Point
    {
        private int _x;
        private int _y;
        public int X { get { return _x; } set { _x = value; } }   
        public int Y { get { return _y; } set { _y = value; } }

        public Point(int y, int x)
        {
            _y = y;
            _x = x;
        }
    }
    public class Shape
    {
        private Point _point;
        public Point Point { get { return _point; } }

        public virtual void Draw (){ }
        public Shape(Point p)
        {
            _point = p;
        }
        public void GetPosition()
        {
            Console.WriteLine($"x = {_point.X}, y = {_point.X}");
        }
    }
    public class Circle : Shape
    {
        private float _radius;
        public Circle(Point point, float radius):base(point)
        {
            _radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"Drtawing a circle, X{Point.X}, Y{Point.Y} raduis{_radius}");
        }
        public double GetArea()
        {
            return _radius * _radius * 3.14; 
        }
        public double GetCirCumference()
        {
            return (_radius * 2) * 3.14;
        }
    }
    public class Rectangle : Shape
    {
        private int _base;
        private int _height;
        public Rectangle(Point point, int b, int h):base(point)
        {
            _base = b;
            _height = h;
        }

        public override void Draw()
        {
            Console.WriteLine($"Base {_base}, Height {_height},. position x {Point.X}  position y {Point.Y}");
        }
    }
        
}

