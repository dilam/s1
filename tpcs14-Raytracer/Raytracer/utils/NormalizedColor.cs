using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Raytracer.utils
{
    /// <summary>
    /// Handle the color information between 0 and 1
    /// </summary>
    /// <remarks>
    /// This is useful to make computations on colors, such as adding them, multiply them,...
    /// </remarks>
    class NormalizedColor
    {
        #region Attributes
        private double r_;
        private double g_;
        private double b_;
        #endregion

        #region Constructors
        public NormalizedColor()
        {
            this.r_ = 0;
            this.g_ = 0;
            this.b_ = 0;
        }

        public NormalizedColor(double r, double g, double b)
        {
            this.r_ = r;
            this.g_ = g;
            this.b_ = b;
        }

        public NormalizedColor(Color c)
        {
            this.r_ = c.R / 255;
            this.g_ = c.G / 255;
            this.b_ = c.B / 255;
        }
        #endregion

        #region Method
        public Color to_color()
        {
            Color result = Color.FromArgb((int)(this.r_ * 255), (int)(this.g_ * 255), (int)(this.b_ * 255));
            return result;
        }
        #endregion

        #region Operators
        public static NormalizedColor operator *(NormalizedColor c1, double d)
        {
            NormalizedColor result = new NormalizedColor(c1.R * d, c1.G * d, c1.B * d);
            return result;
        }

        public static NormalizedColor operator *(NormalizedColor c1, NormalizedColor c2)
        {
            NormalizedColor result = new NormalizedColor(c1.R * c2.R, c1.G * c2.G, c1.B * c2.B);
            return result;
        }

        public static NormalizedColor operator +(NormalizedColor c1, NormalizedColor c2)
        {
            NormalizedColor result = new NormalizedColor(c1.R + c2.R, c1.G + c2.G, c1.B + c2.B);
            return result;
        }
        #endregion

        #region Getters
        public double R
        {
            get { return r_; }
        }

        public double G
        {
            get { return g_; }
        }

        public double B
        {
            get { return b_; }
        }
        #endregion
    }
}
