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
        /// сумма векторов
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        /// <summary>
        /// разность векторов
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        /// <summary>
        /// произведение вектора на число
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Vector operator *(Vector a, double n)
        {
            return new Vector(a.X * n, a.Y * n, a.Z * n);
        }
        /// <summary>
        /// скалярное произведение векторов
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double operator *(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        /// <summary>
        /// векторное произведение векторов
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector operator ^(Vector a, Vector b)
        {
            return new Vector(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
        }
        /// <summary>
        /// Противоположный вектор
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Vector operator -(Vector a)
        {
            return new Vector(-a.X, -a.Y, -a.Z);
        }
        /// <summary>
        /// модуль вектора
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double operator !(Vector a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        }
        /// <summary>
        /// проверка равенства векторов
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Vector n = (Vector)obj;
            return X == n.X && Y == n.Y && Z == n.Z;
        }
        /// <summary>
        /// преобразование вектора в строку
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
