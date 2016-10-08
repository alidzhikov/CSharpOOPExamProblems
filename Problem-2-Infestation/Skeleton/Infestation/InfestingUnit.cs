using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    
    class InfestingUnit : Unit
    {
        public InfestingUnit(string id, UnitClassification unitType, int health, int power, int aggression) : base(id, unitType, health, power, aggression)
        {
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            //This method finds the unit with the least power and attacks it
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, Int32.MaxValue, 0, 0);

            foreach (var unit in attackableUnits)
            {
                if (unit.Health < optimalAttackableUnit.Health)
                {
                    optimalAttackableUnit = unit;
                }
            }

            return optimalAttackableUnit;
        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            bool attackUnit = false;
            if (this.Id != unit.Id)
            {
                UnitClassification thisUnitRequirement = InfestationRequirements.RequiredClassificationToInfest(unit.UnitClassification);
                
                if (this.UnitClassifications.Equals(typeof( thisUnitRequirement)) ){
                    attackUnit = true;
                }
                                 
            }
            return attackUnit;
        }
    }
}
