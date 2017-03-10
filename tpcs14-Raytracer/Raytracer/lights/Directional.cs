using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using Raytracer.utils;

namespace Raytracer.lights
{
    class Directional : Light
    {
        #region Attribute
        private Vector3 dir_;
        #endregion

        #region Constructor
        public Directional(NormalizedColor c, Vector3 dir) : base(c)
        {
            this.dir_ = dir;
        }
        #endregion

        #region Methods
        public override NormalizedColor apply_lightning(NormalizedColor ambient, Material material,
                                                        Ray ray, Vector3 normal, Vector3 point)
        {
            throw new NotImplementedException();
        }

        public override Vector3 get_direction(Vector3 point)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Getter
        public Vector3 Dir
        {
            get { return dir_; }
        }
        #endregion
    }
}
