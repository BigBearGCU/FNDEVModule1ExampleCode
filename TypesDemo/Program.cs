using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Int32 b = 5;
            int c = 1;
            string s = "Thing";
            double d = 3.99;

            Coordinate co = new Coordinate(a, b);
            Console.WriteLine(co.ToString());
            co.Move(2, 2);
            Console.WriteLine(co.ToString());

            Product pr = new Product(c, s, d);
            Console.WriteLine(pr.ToString());
            pr.changePrice(10);
            Console.WriteLine(pr.ToString());

            Direction myDirection = Direction.North;
            // make decision based on enum value
            switch (myDirection)
            {
                case Direction.North:
                    Console.WriteLine("Aberdeen");
                    break;
                case Direction.West:
                    Console.WriteLine("Greenock");
                    break;
                case Direction.South:
                    Console.WriteLine("Dumfries");
                    break;
                case Direction.East:
                    Console.WriteLine("Edinburgh");
                    break;
            }

            Console.ReadKey();
        }
    }

    struct Coordinate
    {
        private int _x, _y;

        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public void Move(int x, int y)
        {
            _x = _x + x;
            _y = _y + y;
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", _x,_y);
        }
    }

    class Product
    {
        private int _id;
        private string _name;
        private double _price;

        public Product(int id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public void changePrice(double percentage)
        {
            _price = _price * (1 + percentage / 100);
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}, {2:c}", _id, _name, _price);
        }
    }

    enum Direction
    {
        North, West, South, East
    }
}
