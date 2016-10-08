using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public struct Weapon : ISupplement
    {
        private int aggressionEffect;
        private int powerEffect;
        public int AggressionEffect
        {
            get
            {
                return this.aggressionEffect;
            }
            private set
            {
                this.aggressionEffect = value;
            }
        }

        public int HealthEffect
        {
            get
            {
                return 0;
            }
        }

        public int PowerEffect
        {
            get
            {
                return this.powerEffect;
            }
            private set
            {
                this.powerEffect = value;
            }
        }

        public void ReactTo(ISupplement otherSupplement)
        {
            this.AggressionEffect = 0;
            this.PowerEffect = 0;
            if (otherSupplement is WeaponrySkill)
            {
                this.AggressionEffect = 3;
                this.PowerEffect = 10;
            }
        }
    }
}
