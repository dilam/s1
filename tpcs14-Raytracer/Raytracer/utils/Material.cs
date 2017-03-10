using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raytracer.utils
{
    class Material
    {
        #region Attributes
        private NormalizedColor diffuse_color_;
        private NormalizedColor spec_color_;
        private float           shininess_;
        #endregion

        #region Constructor
        public Material(NormalizedColor diff, NormalizedColor spec, float shin)
        {
            this.diffuse_color_ = diff;
            this.spec_color_ = spec;
            this.shininess = shin;
        }
        #endregion

        #region Getters & Setters
        public NormalizedColor diffuse
        {
            get { return diffuse_color_; }
            set { this.diffuse_color_ = value; }
        }

        public NormalizedColor specular
        {
            get { return spec_color_; }
            set { this.spec_color_ = value; }
        }

        public float shininess
        {
            get { return shininess_; }
            set { this.shininess_ = value; }
        }

        #endregion
    }
}
