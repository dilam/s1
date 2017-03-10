using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Raytracer.utils;

namespace Raytracer.lights
{
    class PointLight : AttenuationLight
    {

        public PointLight(NormalizedColor c, Vector3 pos, 
                          float cst, float linear, float quadra)
                          : base(c, pos, cst, linear, quadra)
        { /* You do not need to write anything here */ }

        public override NormalizedColor apply_lightning(NormalizedColor ambient, Material material,
                                                        Ray ray, Vector3 normal, Vector3 point)
        {
            throw new NotImplementedException();
        }

        public override Vector3 get_direction(Vector3 point)
        {
            throw new NotImplementedException();
        }

        #region getters/setters
        public Vector3 position_get
        {
            get { return this.pos_; }
        }
        #endregion
    }
}
