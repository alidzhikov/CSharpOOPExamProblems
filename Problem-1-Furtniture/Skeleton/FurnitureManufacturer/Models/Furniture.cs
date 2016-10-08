namespace FurnitureManufacturer.Models
{
    using System;
    using Interfaces;

    class Furniture : IFurniture
    {
        private string model;
        private MaterialType material;
        protected decimal height;
        protected decimal price;

        public Furniture(string model, MaterialType material, decimal price, decimal height )
        {
            
            this.Model = model;
            this.material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            protected set
            {
                this.model = value;
            }
        }
        public string Material
        {
            get
            {
                return this.material.ToString();
            }
        }
        public decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                this.height = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price; 
            }

            set
            {
                this.price = value;
            }
        }
    }
}
