using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public struct Coordinate<T>
    {
        private T _x, _y;

        public Coordinate(T x, T y)
        {
            _x = x;
            _y = y;
        }

        public void MoveTo(T x, T y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return string.Format("x - {0} y - {1}",_x,_y);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Coordinate<int> myIntCoord = new Coordinate<int>(5, 0);
            Console.WriteLine("Int Coord {0}", myIntCoord.ToString());

            Coordinate<float> myFloatCoord = new Coordinate<float>(5.0f, 10.0f);
            myFloatCoord.MoveTo(10.0f, 10.0f);
            Console.WriteLine("Float Coord {0}", myFloatCoord.ToString());

            Console.ReadKey();
        }
    }
}
