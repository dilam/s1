using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Raytracer.utils;

namespace Raytracer.shapes
{
    abstract class Shape
    {
        #region Attribute
        private Material mat_;
        #endregion

        #region Constructor
        public Shape(Material mat)
        {
            this.mat_ = mat;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the intersection point as a Vector3 relative to a given ray.
        /// </summary>
        /// <param name="ray">The 3D ray intersecting or not the shape instance</param>
        /// <returns>A Vector3 representing the intersection point. NULL otherwise</returns>
        public abstract Vector3 intersect(Ray ray);

        /// <summary>
        /// Computes the normal to the surface at a given 3D point
        /// </summary>
        /// <param name="point">The Vector3 point on the shape surface</param>
        /// <returns>The normalized Vector3 representing the normal</returns>
        public abstract Vector3 normal_at_point(Vector3 point);
        #endregion

        #region Getters
        public Material Mat
        {
            get { return mat_; }
        }

        #endregion
    }
}
