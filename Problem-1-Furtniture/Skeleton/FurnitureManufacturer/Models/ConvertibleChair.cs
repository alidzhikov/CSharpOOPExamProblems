

namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;

    class ConvertibleChair : Chair,IConvertibleChair
    {
        private bool state = false;
        public ConvertibleChair(string model, MaterialType material, decimal price, decimal height, int legs) : base(model, material,price, height, legs)
        {
        }

        public bool IsConverted
        {
            get
            {
                if (this.state)
                    return true;
                else
                return false;
            }
        }

        public override int NumberOfLegs
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

        public void Convert()
        {
            this.state = true;
        }

        public override string ToString()
        {
            return String.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}"
                , this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal");
        }
    }
}
