using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskVector
{
    public class Vector
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Vector operator *(Vector a, double n)
        {
            return new Vector(a.X * n, a.Y * n, a.Z * n);
        }
        public static double operator *(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

    }
}
