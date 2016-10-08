using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class InfestationSpores : ISupplement
    {
        private int aggressionEffect = 20;
        private int powerEffect = 1;
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
            if(otherSupplement is InfestationSpores)
            {
                this.aggressionEffect = 0;
                this.powerEffect = 0;
            }
        }
    }
}
