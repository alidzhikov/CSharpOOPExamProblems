namespace FurnitureManufacturer.Models
{
    using System;
    using Interfaces;

    class Table : Furniture,ITable
    {
        protected decimal length, width;
        public Table(string model, MaterialType material, decimal price, decimal height, decimal length, decimal width) : base(model, material, price, height)
        {
            this.length = length;
            this.width = width;
        }

        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
        }

        public override string ToString()
        {
            return String.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}"
                , this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.Length, this.Width, this.Area);
        }
    }
}
