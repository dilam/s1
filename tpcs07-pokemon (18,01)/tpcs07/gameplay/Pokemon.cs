using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpcs07
{
    public class Pokemon
    {
        private string  name_;
        private int     pv_;
        private int     pv_max_;
        private int     lvl_;

        private Attack[] attack_tab_;
        private PokemonType type_;

        public Pokemon(string name, PokemonType type, int lvl, int PV)
        {
            this.name_ = name;
            this.type_ = type;
            this.lvl_ = lvl;
            this.pv_max_ = PV;
            this.pv_ = PV;

            this.attack_tab_ = new Attack[4];
        }

        public string who_am_i()
        {
            if (lvl_ < 10)
            {
                return "and I am quite weak";
            }
            else if (lvl_ < 25)
            {
                return "and I am still under training";
            }
            else if (lvl_ < 50)
            {
                return "and I am ready to battle";
            }
            else if (lvl_ < 75)
            {
                return "and I am quite strong";
            }
            return "and you cannot beat me";
        }

        public void undergo(Attack a)
        {
            if(a.damage_get() > pv_)
            {
                pv_ = 0;
            }
            pv_ = pv_ - a.damage_get();
        }

        #region Gets/Set
        public string name
        {
            get { return name_; }
            private set { name_ = value; }
        }

        public PokemonType type
        {
            get { return type_; }
            private set { type_ = value; }
        }

        public int pv
        {
            get { return pv_; }
            private set { pv_ = value; }
        }

        public int pv_max
        {
            get { return pv_max_; }
            private set { pv_max_ = value; }
        }

        public int lvl
        {
            get { return lvl_; }
            private set { lvl_ = value; }
        }

        public void set_attack(Attack new_attack, int n)
        {
            attack_tab_[n] = new_attack;
        }

        public Attack get_attack(int n)
        {
            return attack_tab_[n];
        }

        public bool is_alive()
        {
            if (pv_ <= 0)
            {
                return false;
            }
            return true;
        }
        #endregion
    }

    public enum PokemonType
    {
        Pikachu,
        Dracaufeu,
        Lockhlass,
        Smogogo,
        Spectrum,
        Aquali
    };
}