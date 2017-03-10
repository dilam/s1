using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpcs07
{
    public class Arena
    {
        Pokemon mine_, opponent_, attacking_, undergoing_;
        public Arena(Pokemon left, Pokemon right)
        {
            this.attacking_ = left;
            this.undergoing_ = right;
            this.mine_ = left;
            this.opponent_ = right;
        }

        public void change_attacker()
        {
            Pokemon p = attacking_;
            attacking_ = undergoing_;
            undergoing_ = p;
        }

        public void attack_with(int n)
        {
            undergoing_.undergo(attacking_.get_attack(n));
        }

        public bool is_finished()
        {
            if (undergoing_.is_alive() && attacking_.is_alive())
            {
                return false;
            }
            return true;
        }

        #region
        public Pokemon left
        {
            get { return mine_; }
            private set { mine_ = value; }
        }

        public Pokemon right
        {
            get { return opponent_; }
            private set { opponent_ = value; }
        }
        #endregion
    }
}
