namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;

    class Chair : Furniture, IChair
    {
        protected int legs;
        public Chair(string model, MaterialType material, decimal price, decimal height, int legs) : base(model, material, price, height)
        {
            this.NumberOfLegs = legs;
        }

        public virtual int NumberOfLegs
        {
            get
            {
                return this.legs;
            }
            set
            {
                this.legs = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}"
                , this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs);
        }
    }
}
