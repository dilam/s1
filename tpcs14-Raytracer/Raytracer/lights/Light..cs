using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Raytracer.utils;

namespace Raytracer
{
    abstract class Light
    {
        #region Attribute
        protected NormalizedColor color_;
        #endregion

        #region Constructor
        public Light(NormalizedColor c)
        {
            this.color_ = c;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Compute the resulting lightning color
        /// </summary>
        /// <param name="ambient">The ambient color relative to the scene</param>
        /// <param name="material">The shape's material</param>
        /// <param name="ray">The ray coming from the viewer eye</param>
        /// <param name="normal">The normal at the point of intersection</param>
        /// <param name="point">The point of the intersection</param>
        /// <returns></returns>
        public abstract NormalizedColor apply_lightning(NormalizedColor ambient, Material material,
                                                        Ray ray, Vector3 normal, Vector3 point);

        /// <summary>
        /// The direction of the light according to the intersection Point
        /// For a directional, it is simply the direction of the light,
        /// but for light without direction, it's the vector between the point position and the light position
        /// </summary>
        /// <param name="point">The point of intersection</param>
        /// <returns>The direction vector obtained from the current light</returns>
        public abstract Vector3 get_direction(Vector3 point);

        /// <summary>
        /// Get the specular factor for a given point
        /// </summary>
        /// <param name="ray">The ray coming from the viewer eye</param>
        /// <param name="init_dir">The direction of the light(direction toward the point for a point light)</param>
        /// <param name="point">The point of intersection</param>
        /// <param name="normal">The normal the point of intersection</param>
        /// <param name="shininess">The reflective coefficient of the shape material</param>
        /// <returns></returns>
        public double specular_get(Ray ray, Vector3 init_dir, Vector3 point,
                                   Vector3 normal, float shininess)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Getter
        public NormalizedColor Color
        {
            get { return color_; }
        }
        #endregion
    }
}
