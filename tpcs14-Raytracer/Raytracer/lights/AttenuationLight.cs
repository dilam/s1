using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raytracer.utils;

namespace Raytracer.lights
{
    abstract class AttenuationLight : Light
    {
        protected   Vector3 pos_;
        private     float   constant_;
        private     float   linear_;
        private     float   quadratic_;

        public AttenuationLight(NormalizedColor c, Vector3 pos, 
                                float cst, float linear, float quadratic) : base(c)
        {
            this.pos_ = pos;
            this.constant_ = cst;
            this.linear_ = linear;
            this.quadratic_ = quadratic;
        }

        protected double attenuation_get(Vector3 point)
        {
            double distance = point.norm();

            return 1 / (0.5 + 0.09 * distance + 0.032 * distance * distance);
        }
    }
}
