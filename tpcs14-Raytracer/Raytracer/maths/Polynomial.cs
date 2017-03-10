using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer.utils
{
    class Polynomial
    {
        #region Attributes
        private double[] coefs_;
        private uint n_;
        #endregion

        #region Constructor
        public Polynomial(double[] coefs, uint n)
        {
            this.coefs_ = coefs;
            this.n_ = n;
        }
        #endregion  

        #region Methods
        /// <summary>
        /// Solves a second degree polynomial equation
        /// </summary>
        /// <param name="squares">The array representing the different coefficients</param>
        /// <returns>1 if the solution is unique, 2 if the equation has two roots, 0 otherwise</returns>
        public uint resolve_quadratic(ref double[] squares)
        {
            double delta = coefs_[1] * coefs_[1] - 4 * coefs_[0] * coefs_[2];
            int lon = squares.Length;
            uint result = 0;

            if (delta == 0)
            {
                result = 1;

                double[] square = new double[lon + 1];
                square.CopyTo(squares, 0);
                square[lon] = -coefs_[1] / (2 * coefs_[0]);
                squares = square;
            }

            if (delta > 0)
            {
                result = 2;
                double[] square = new double[lon + 2];
                square.CopyTo(squares, 0);
                square[lon] = (-coefs_[1] - Math.Sqrt(delta)) / (2 * coefs_[0]);
                square[lon + 1] = (-coefs_[1] + Math.Sqrt(delta)) / (2 * coefs_[0]);
                squares = square;
            }

            return result;
        }

        /// <summary>
        /// Solves a third degree polynomial equation
        /// </summary>
        /// <param name="squares">The array representing the different coefficients</param>
        /// <returns>1 if the solution is unique, 3 if the equation has three roots</returns>
        public uint resolve_cubic(ref double[] squares)
        {
            double p = coefs_[1] / coefs_[0];
            double q = coefs_[2] / coefs_[0];
            double delta = (q * q) / 4 + (p * p * p) / 27;
            int lon = squares.Length;
            uint result = 0;

            if (delta > 0)
            {
                result = 1;

                double[] square = new double[lon + 1];
                square.CopyTo(squares, 0);
                square[lon] = Math.Pow(-q / 2 + Math.Sqrt(delta), (1.0 / 3.0)) + Math.Pow(-q / 2 - Math.Sqrt(delta), (1.0 / 3.0));
                squares = square;
            }
            else if (delta == 0)
            {
                result = 2;

                double[] square = new double[lon + 2];
                square.CopyTo(squares, 0);
                square[lon] = 3 * q / p;
                square[lon + 1] = (-3 * q) / (2 * p);
                squares = square;
            }
            else
            {
                result = 3;

                double[] square = new double[lon + 3];
                square.CopyTo(squares, 0);
                double phi = Math.Acos(((3 * q) / (2 * p)) * Math.Sqrt(-3 / p));
                square[lon] = 2 * Math.Sqrt(-p / 3) * Math.Cos(phi / 3);
                square[lon + 1] = Math.Sqrt(-p / 3) * (-Math.Cos(phi / 3) + Math.Sqrt(3) * Math.Sin(phi / 3));
                square[lon + 2] = Math.Sqrt(-p / 3) * (-Math.Cos(phi / 3) - Math.Sqrt(3) * Math.Sin(phi / 3));
                squares = square;
            }

            return result;
        }
        #endregion
    }
}
