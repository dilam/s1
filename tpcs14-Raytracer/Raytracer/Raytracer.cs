using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using Raytracer.shapes;
using Raytracer.utils;

namespace Raytracer
{
    class Raytracer
    {
        #region Attributes
        private static Raytracer instance_;
        private Bitmap           image_;
        #endregion

        #region Constructor
        private Raytracer()
        { }
        #endregion

        #region Method
        /// <summary>
        /// Generate a bitmap from a 3D scene.
        /// </summary>
        /// <param name="cam">The camera through which the scene is seen</param>
        /// <param name="screen">The screen to render on</param>
        /// <param name="nodes">The list of shapes belonging to the scene</param>
        /// <param name="lights">The list of light belonging to the scene</param>
        /// <param name="ambient">The scene ambient color</param>
        /// <param name="pb">The progess bar to increase during the rendering</param>
        /// <returns></returns>
        public Bitmap render_image(Camera cam, utils.Screen screen, List<Shape> nodes, 
                                   List<Light> lights, NormalizedColor ambient,
                                   ProgressBar pb)
        {
            image_ = new Bitmap(screen.Width, screen.Height);

            Ray ray = null;
            // Saves the pixel color to apply on the image
            NormalizedColor pixel_color = null;

            int x = 0;
            int y = screen.Height - 1;
            for (int height = -screen.Height / 2; height < screen.Height / 2; ++height, --y, x = 0)
            {
                for (int width = -screen.Width / 2; width < screen.Width / 2; ++width, ++x)
                {
                    // Get the ray coming from the viewer eye
                    ray = Ray.get_ray(x, y, screen, cam);

                    // FIXME: Checks for intersection
                        // FIXME: Computes lightning
                        // FIXME: Comptues shadowing

                    // Do not forget to save the pixel color into the variable pixel_color
                    // This line adds the new pixel to the image
                    image_.SetPixel(x, y, pixel_color.to_color());
                }
                // Update the progress bar animation
                pb.Value++;
            }

            return image_;
        }

        /// <summary>
        /// Check wheter there is an intersection for a particular rays
        /// </summary>
        /// <param name="ray">The ray on which the intersection is applied</param>
        /// <param name="nodes">The shape list in which we are looking for an intersection</param>
        /// <param name="point">The variable containing the resulting point of intersection if exists, NULL otherwise</param>
        /// <param name="shape">The variable containing the resulting insertected shape if exists, NULL otherwise</param>
        private void get_intersection(Ray ray, List<Shape> nodes,
                                      ref Vector3 point, ref Shape shape)
        {
            point = null;
            shape = null;

            foreach (Shape n in nodes)
            {
                Vector3 intersection_point = n.intersect(ray);

                if (intersection_point != null
                    && (point == null
                        || Vector3.distance(new Vector3(), point) < Vector3.distance(new Vector3(), point)))
                {
                    point = intersection_point;
                    shape = n;
                }
            }
        }

        /// <summary>
        /// Check whether a surface is submitted to shadows or not.
        /// </summary> 
        /// <param name="nodes">The shape list in which we are looking for the shadowing</param>
        /// <param name="intersection_shape">The current shape on which the shadowing is checked</param>
        /// <param name="intersection_point">The current point of intersection of the shape on which the shadowing is checked</param>
        /// <param name="l">The emitting light that could produce the shadow</param>
        /// <returns></returns>
        private Boolean is_shadowed_by_light(List<Shape> nodes, Shape intersection_shape,
                                    Vector3 intersection_point, Light l)
        {
            // Compute shadows
            foreach (Shape n in nodes)
            {
                if (intersection_shape == n)
                    continue;

                Vector3 direction = l.get_direction(intersection_point) * -1;
                if (n.intersect(new Ray(intersection_point, direction)) != null)
                    return true;
            }
            return false;
        }
        #endregion

        #region Getter
        public Bitmap Img
        {
            get { return image_; }
        }
        #endregion

        #region Singleton
        public static Raytracer Instance
        {
            get
            {
                if (instance_ == null)
                    instance_ = new Raytracer();
                return instance_;
            }
        }
        #endregion
    }
}
