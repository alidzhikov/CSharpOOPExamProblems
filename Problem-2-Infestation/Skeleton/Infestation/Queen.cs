using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class Queen : InfestingUnit
    {
        const int QueenPower = 1;
        const int QueenAggression = 1;
        const int QueenHealth = 30;

        public Queen(string id)
            : base(id, UnitClassification.Psionic, Queen.QueenHealth, Queen.QueenPower ,Queen.QueenAggression)
        {
            this.AddSupplement(new InfestationSpores());
        }


    }
}
