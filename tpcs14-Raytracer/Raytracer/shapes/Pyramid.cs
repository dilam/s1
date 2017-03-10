using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Raytracer.utils;

namespace Raytracer.shapes
{
    class Pyramid : Shape
    {
        private PyramidFace[] triangle_faces_;
        private PyramidFace   inter_face_;
        private CubeFace      base_face_;

        public Pyramid(Material mat, Vector3 pos, float base_size, float height) : base(mat)
        {
            base_face_ = new CubeFace(mat, new Vector3(pos.X + base_size / 2, pos.Y, pos.Z - base_size / 2),
                                           new Vector3(pos.X - base_size / 2, pos.Y, pos.Z - base_size / 2),
                                           new Vector3(pos.X + base_size / 2, pos.Y, pos.Z + base_size / 2));

            // Contains all the triangles faces belonging to the pyramid
            triangle_faces_ = new PyramidFace[4];

            triangle_faces_[0] = new PyramidFace(mat, new Vector3(pos.X + base_size / 2, pos.Y, pos.Z - base_size / 2), new Vector3(pos.X + base_size / 2, pos.Y, pos.Z - base_size / 2), new Vector3(pos.X, pos.Y + height, pos.Z));
            triangle_faces_[1] = new PyramidFace(mat, new Vector3(pos.X - base_size / 2, pos.Y, pos.Z - base_size / 2), new Vector3(pos.X - base_size / 2, pos.Y, pos.Z - base_size / 2), new Vector3(pos.X, pos.Y + height, pos.Z));
            triangle_faces_[2] = new PyramidFace(mat, new Vector3(pos.X - base_size / 2, pos.Y, pos.Z - base_size / 2), new Vector3(pos.X + base_size / 2, pos.Y, pos.Z - base_size / 2), new Vector3(pos.X, pos.Y + height, pos.Z));
            triangle_faces_[3] = new PyramidFace(mat, new Vector3(pos.X - base_size / 2, pos.Y, pos.Z + base_size / 2), new Vector3(pos.X + base_size / 2, pos.Y, pos.Z + base_size / 2), new Vector3(pos.X, pos.Y + height, pos.Z));
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
