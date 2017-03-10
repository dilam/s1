using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Raytracer.utils;

namespace Raytracer.shapes
{
    class Cube : Shape
    {
        private Vector3    pos_;
        private float      size_;
        private CubeFace[] faces_;
        private CubeFace   inter_face_;

        public Cube(Material mat, Vector3 pos, float s) : base(mat)
        {
            pos_ = pos;
            size_ = s;

            faces_ = new CubeFace[6];
            
            faces_[0] = new CubeFace(mat, new Vector3(pos.X + s / 2, pos.Y + s / 2, pos.Z - s / 2), new Vector3(pos.X + s / 2, pos.Y - s / 2, pos.Z - s / 2), new Vector3(pos.X - s / 2, pos.Y + s / 2, pos.Z - s / 2));
            faces_[1] = new CubeFace(mat, new Vector3(pos.X + s / 2, pos.Y + s / 2, pos.Z + s / 2), new Vector3(pos.X + s / 2, pos.Y - s / 2, pos.Z + s / 2), new Vector3(pos.X - s / 2, pos.Y + s / 2, pos.Z + s / 2));
            faces_[2] = new CubeFace(mat, new Vector3(pos.X - s / 2, pos.Y + s / 2, pos.Z - s / 2), new Vector3(pos.X - s / 2, pos.Y - s / 2, pos.Z - s / 2), new Vector3(pos.X - s / 2, pos.Y + s / 2, pos.Z + s / 2));
            faces_[3] = new CubeFace(mat, new Vector3(pos.X + s / 2, pos.Y + s / 2, pos.Z - s / 2), new Vector3(pos.X + s / 2, pos.Y - s / 2, pos.Z - s / 2), new Vector3(pos.X + s / 2, pos.Y + s / 2, pos.Z + s / 2));
            faces_[4] = new CubeFace(mat, new Vector3(pos.X + s / 2, pos.Y - s / 2, pos.Z - s / 2), new Vector3(pos.X - s / 2, pos.Y - s / 2, pos.Z - s / 2), new Vector3(pos.X - s / 2, pos.Y - s / 2, pos.Z + s / 2));
            faces_[5] = new CubeFace(mat, new Vector3(pos.X + s / 2, pos.Y + s / 2, pos.Z - s / 2), new Vector3(pos.X - s / 2, pos.Y + s / 2, pos.Z - s / 2), new Vector3(pos.X - s / 2, pos.Y + s / 2, pos.Z + s / 2));
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
