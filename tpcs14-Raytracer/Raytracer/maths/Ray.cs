using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer.utils
{
    class Ray
    {
        #region Attributes
        private Vector3 origin_;
        private Vector3 dir_;
        #endregion

        #region Constructor
        public Ray(Vector3 origin, Vector3 dir)
        {
            this.origin_ = origin;
            this.dir_ = dir;
        }
        #endregion

        #region Method
        /// <summary>
        /// Computes a Ray from the x and y position on the 3D projection screen and the camera
        /// </summary>
        /// <param name="x">The position of the 3D pixel along the x-axis</param>
        /// <param name="y">The position of the 3D pixel along the y-axis</param>
        /// <param name="screen">The 3D screen</param>
        /// <param name="cam">The camera representing the viewer point of view</param>
        /// <returns></returns>
        public static Ray get_ray(int x, int y, Screen screen, Camera cam)
        {
            Vector3 O = cam.Pos;
            int dx = x - screen.Width / 2;
            int dy = y - screen.Height / 2;
            Vector3 D = screen.Center + cam.U * dx + cam.V * dy - cam.Pos;
            D.normalize();
            return new Ray(O, D);
        }
        #endregion

        #region Getters
        public Vector3 Origin
        {
            get { return origin_; }
        }

        public Vector3 Dir
        {
            get { return dir_; }
        }

        #endregion
    }
}
