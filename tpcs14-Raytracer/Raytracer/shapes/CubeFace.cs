using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Raytracer.utils;

namespace Raytracer.shapes
{
    class CubeFace : Shape
    {
        private Vector3 point_a_;
        private Vector3 point_b_;
        private Vector3 point_c_;

        public CubeFace(Material mat ,Vector3 point_a, Vector3 point_b, Vector3 point_c) : base(mat)
        {
            this.point_a_ = point_a;
            this.point_b_ = point_b;
            this.point_c_ = point_c;
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
