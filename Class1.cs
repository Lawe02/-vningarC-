using Newtonsoft.Json;

namespace Övningar
{
    internal class Class1
    {
        public void Go()
        {

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
}

