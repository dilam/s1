using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer.utils
{
    class Screen
    {
        private const double PI_4 = 0.7853981633d;

        #region Attributes
        private int width_;
        private int height_;
        private Vector3 center_;
        #endregion

        #region Constructor
        public Screen(int width, int height)
        {
            this.width_ = width;
            this.height_ = height;
        }
        #endregion

        #region Method
        /// <summary>
        /// Centers the current screen instance according to a given camera
        /// </summary>
        /// <param name="cam">The camera used as a "point of reference"</param>
        public void set_center(Camera cam)
        {
            double L = (width_ / 2) / Math.Tan(45 / 2);
            Vector3 w = cam.U * cam.V;
            Vector3 C = cam.Pos + L * w;
            this.center_ = C;
        }
        #endregion

        #region Getters & Setters
        public int Width
        {
            get { return width_; }
            set { this.width_ = value; }
        }

        public int Height
        {
            get { return height_; }
            set { this.height_ = value; }
        }

        public Vector3 Center
        {
            get { return center_; }
        }
        #endregion
    }
}
