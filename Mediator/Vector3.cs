using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Vector3
    {
        public Vector3(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        private readonly double _x, _y, _z;

        public double X
        {
            get { return _x; }
        }

        public double Y
        {
            get { return _y; }
        }

        public double Z
        {
            get { return _z; }
        }

        public double GetDistance(Vector3 v)
        {
            return Math.Sqrt((X - v.X)*(X - v.X) + (Y - v.Y)*(Y - v.Y) + (Z - v.Z)*(Z - v.Z));
        }

        public override string ToString()
        {
            return String.Format("({0},{1},{2})", X, Y, Z);
        }
    }
}
