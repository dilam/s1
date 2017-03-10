using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Raytracer.utils;

namespace Raytracer.shapes
{
    class Sphere : Shape
    {
        #region Attributes
        private float radius_;
        private Vector3 pos_;
        #endregion

        #region Constructor
        public Sphere(Material mat, Vector3 position, float radius) : base(mat)
        {
            this.radius_ = radius;
            this.pos_ = position;
        }
        #endregion

        #region Methods
        public override Vector3 intersect(Ray ray)
        {
            double[] coefs = new double[3];
            double D = ray.Dir.norm();
            double O = ray.Origin.norm();
            double C = pos_.norm();
            coefs[0] = D * D;
            coefs[1] = 2 * D * (O - C);
            coefs[2] = (O - C) * (O - C) - radius_ * radius_;

            double[] sol = new double[0];
            Polynomial spher = new Polynomial(coefs, 2);
            uint nbSol = spher.resolve_quadratic(ref sol);

            throw new NotImplementedException();

            // Retourner l'intersection la plus proche de la camera (creer une ligne de la camera pasant par les 2 intersections et retourner la plus proche)
        }

        public override Vector3 normal_at_point(Vector3 point)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
