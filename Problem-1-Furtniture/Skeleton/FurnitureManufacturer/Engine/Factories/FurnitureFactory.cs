﻿namespace FurnitureManufacturer.Engine.Factories
{
    using System;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            MaterialType matType = GetMaterialType(materialType);
            return new Table(model, matType, price, height, length, width);
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            MaterialType matType = GetMaterialType(materialType);
            return new Chair(model, matType, price, height, numberOfLegs);
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs,string type)
        {
            MaterialType matType = GetMaterialType(materialType);
            switch (type.ToLower())
            {
                case "adjustable":
                    return new AdjustableChair(model, matType,  price, height, numberOfLegs);
                case "convertible":
                    return new ConvertibleChair(model, matType,  price, height, numberOfLegs);
                default:
                    return new Chair(model, matType,  price, height, numberOfLegs);
            }
            
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            MaterialType matType = GetMaterialType(materialType);
            return new AdjustableChair(model, matType, price, height, numberOfLegs);
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            MaterialType matType = GetMaterialType(materialType);
            return new ConvertibleChair( model, matType, price, height, numberOfLegs);
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }
    }
}
