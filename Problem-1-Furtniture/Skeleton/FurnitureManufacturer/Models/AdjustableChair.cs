namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;

    class AdjustableChair : Chair,IAdjustableChair
    {
        public AdjustableChair(string model, MaterialType material, decimal price, decimal height, int legs) : base(model,material, price, height, legs)
        {        
        }

        public void SetHeight(decimal height)
        {
            this.height = height;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
