using System;

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
        /// <summary>
        /// Sum of the vectors
        /// </summary>
        /// <param name="a">Vector a</param>
        /// <param name="b">Vector b</param>
        /// <returns></returns>
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        /// <summary>
        /// The difference of vectors
        /// </summary>
        /// <param name="a">Vector a</param>
        /// <param name="b">Vector b</param>
        /// <returns></returns>
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        /// <summary>
        /// Multiplying a vector by a number
        /// </summary>
        /// <param name="a">Vector a</param>
        /// <param name="n">Number n</param>
        /// <returns></returns>
        public static Vector operator *(Vector a, double n)
        {
            return new Vector(a.X * n, a.Y * n, a.Z * n);
        }
        /// <summary>
        /// Scalar multiplication of vectors
        /// </summary>
        /// <param name="a">Vector a</param>
        /// <param name="b">Vector b</param>
        /// <returns></returns>
        public static double operator *(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        /// <summary>
        /// Vector multiplication of vectors
        /// </summary>
        /// <param name="a">Vector a</param>
        /// <param name="b">Vector b</param>
        /// <returns></returns>
        public static Vector operator ^(Vector a, Vector b)
        {
            return new Vector(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
        }
        /// <summary>
        /// Inverse vector
        /// </summary>
        /// <param name="a">Vector a</param>
        /// <returns></returns>
        public static Vector operator -(Vector a)
        {
            return new Vector(-a.X, -a.Y, -a.Z);
        }
        /// <summary>
        /// The module of the vector
        /// </summary>
        /// <param name="a">Vector a</param>
        /// <returns></returns>
        public static double operator !(Vector a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        }
        /// <summary>
        /// Converting a vector to a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }
        /// <summary>
        /// Checking the equality of vectors
        /// </summary>
        /// <param name="obj">Vector</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Vector n = (Vector)obj;
            return X == n.X && Y == n.Y && Z == n.Z;
        }
        /// <summary>
        /// Implementation GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                hash = hash * 23 + Z.GetHashCode();
                return hash;
            }
        }
    }
}
