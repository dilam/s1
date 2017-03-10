using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpcs07
{
    public class Attack
    {
        static Random   rand_ = new Random(Guid.NewGuid().GetHashCode());

        private string  name_;
        private int     min_damage_;
        private int     max_damage_;

        private int     critical_rate_;
        private int     critical_fail_rate_;
        private int     critical_bonus_rate_;

        public Attack(string name, int min, int max, int crit_rate,
                      int crit_fail_rate, int crit_bonus_rate)
        {
            this.name_ = name;
            this.min_damage_ = min;
            this.max_damage_ = max;
            this.critical_rate_ = crit_rate;
            this.critical_fail_rate_ = crit_fail_rate;
            this.critical_bonus_rate_ = crit_bonus_rate;
        }

        public int damage_get()
        {
            int r = rand_.Next(0, 100);
            float d = rand_.Next(min_damage_, max_damage_);
            float crit = critical_bonus_rate_ / 100 + 1;
            if (r < critical_rate_)
            {
                return (int)(d * crit);
            }
            else if (r > (100 - critical_fail_rate_))
            {
                return 0;
            }
            return (int)d;
        }

        public string name
        {
            get { return name_; }
        }
    }
}
