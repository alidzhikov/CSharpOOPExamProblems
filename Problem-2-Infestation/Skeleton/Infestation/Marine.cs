using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class Marine : Human
    {
        public Marine(string id) : base(id)
        {
            this.AddSupplement(new WeaponrySkill());
        }
        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);
            var units = attackableUnits.Where(unit => unit.Power <= this.Aggression);
            
            foreach(var unit in units)
            {
                if(unit.Health > optimalAttackableUnit.Health)
                {
                    optimalAttackableUnit = unit;
                }
            }
            return optimalAttackableUnit;
        }
    }
}
