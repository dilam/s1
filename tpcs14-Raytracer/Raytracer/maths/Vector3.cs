using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer
{
    /// <summary>
    /// Vector class containg 3 coordinates
    /// </summary>
    /// <remarks>
    /// Allows to perform computation on vectors easily
    /// </remarks>
    class Vector3
    {
        #region Attributes
        private double x_;
        private double y_;
        private double z_;
        #endregion

        #region Constructors
        public Vector3()
        {
            this.x_ = 0;
            this.y_ = 0;
            this.z_ = 0;
        }

        public Vector3(double x, double y, double z)
        {
            this.x_ = x;
            this.y_ = y;
            this.z_ = z;
        }
        #endregion

        #region Methods
        public double norm()
        {
            return Math.Sqrt(x_ * x_ + y_ * y_ + z_ * z_);
        }

        /// <summary>
        /// Transforms the the current instance of the Vector3 to its normalized form
        /// </summary>
        public void normalize()
        {
            double lon = norm();

            this.x_ = this.x_ / lon;
            this.y_ = this.y_ / lon;
            this.z_ = this.z_ / lon;
        }

        /// <summary>
        /// Computes the Euclidian distance between two Vector3
        /// </summary>
        /// <param name="p1">The first vector</param>
        /// <param name="p2">The second vector</param>
        /// <returns>A double representing the euclidian distance between the two vectors</returns>
        public static double distance(Vector3 p1, Vector3 p2)
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y) + (p2.Z - p1.Z) * (p2.Z - p1.Z));
        }
        #endregion

        #region Operators
        /// <summary>
        /// Computes the dot product of the two given Vector3
        /// </summary>
        /// <param name="v1">The first vector</param>
        /// <param name="v2">The second vector</param>
        /// <returns>A double representing the dot product between the two vectors</returns>
        public static double operator |(Vector3 v1, Vector3 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            Vector3 result = new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
            return result;
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            Vector3 result = new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
            return result;
        }

        public static Vector3 operator *(Vector3 v1, Vector3 v2)
        {
            double X = v1.Y * v2.Z - v1.Z * v2.Y;
            double Y = v1.Z * v2.X - v1.X * v2.Z;
            double Z = v1.X * v2.Y - v1.Y * v2.X;
            Vector3 result = new Vector3(X, Y, Z);
            return result;
        }

        public static Vector3 operator *(Vector3 v, double d)
        {
            Vector3 result = new Vector3(d * v.X, d * v.Y, d * v.Z);
            return result;
        }

        public static Vector3 operator *(double d, Vector3 v)
        {
            Vector3 result = new Vector3(d * v.X, d * v.Y, d * v.Z);
            return result;
        }
        #endregion

        #region Getters & Setters
        public double X
        {
            get { return x_; }
            set { x_ = value; }
        }

        public double Y
        {
            get { return y_; }
            set { y_ = value; }
        }

        public double Z
        {
            get { return z_; }
            set { z_ = value; }
        }
        #endregion
    }
}
