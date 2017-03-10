using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Raytracer.utils;

namespace Raytracer.lights
{
    class SpotLight : AttenuationLight
    {
        private Vector3 dir_;
        private float outer_cut_off_;
        private float cut_off_;

        public SpotLight(NormalizedColor c, Vector3 pos, Vector3 dir,
                         float cut_off = 0.984f, float outer_cut_off = 0.965f,
                         float cst = 0, float linear = 0, float quadratic = 0)
                         : base(c, pos, cst, linear, quadratic)
        {
            throw new NotImplementedException();
        }

        public override NormalizedColor apply_lightning(NormalizedColor ambient, Material material,
                                                        Ray ray, Vector3 normal, Vector3 point)
        {
            throw new NotImplementedException();
        }

        public override Vector3 get_direction(Vector3 point)
        {
            throw new NotImplementedException();
        }
    }
}
