using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Raytracer.utils;

namespace Raytracer.shapes
{
    class Plane : Shape
    {
        private const double EPSILON = 0.00001;
        private double a_;
        private double b_;
        private double c_;
        private double d_;

        private Vector3 normal_;

        public Plane(Material mat, double a, double b,
                     double c, double d) : base (mat)
        {
            this.a_ = a;
            this.b_ = b;
            this.c_ = c;
            this.d_ = d;
        }

        public override Vector3 intersect(Ray ray)
        {
            throw new NotImplementedException();
        }

        public override Vector3 normal_at_point(Vector3 point)
        {
            throw new NotImplementedException();
        }
    }
}
