

namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;
    using Interfaces.Engine;
    using Engine.Factories;

    class Company : ICompany
    {
        private string name, registrationNumber;
        private List<IFurniture> furnitures = new List<IFurniture>();

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            private set
            {
                this.registrationNumber = value;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
            //this.furnitures.OrderBy();
        }

        public string Catalog()
        {
            StringBuilder catalogStr = new StringBuilder();
            catalogStr.Append(  String.Format("{0} - {1} - {2} {3}\n",
                this.Name, this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture")
                );

            if(this.Furnitures.Count > 0)
            {
                foreach(var furniture in this.Furnitures)
                {
                    catalogStr.AppendLine(furniture.ToString());
                }
            }

            return catalogStr.ToString();
        }

        public IFurniture Find(string model)
        {
            return this.Furnitures
                .Where(x => x.Model.ToLowerInvariant() == model.ToLowerInvariant())
                .FirstOrDefault();
        }

        public void Remove(IFurniture furniture)
        {
            this.Furnitures.Remove(furniture);
        }
    }
}
