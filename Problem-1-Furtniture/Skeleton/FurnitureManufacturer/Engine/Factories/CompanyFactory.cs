namespace FurnitureManufacturer.Engine.Factories
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class CompanyFactory : ICompanyFactory
    {
        public ICompany CreateCompany(string name, string registrationNumber)
        {
            Company newCompany = new Company(name, registrationNumber);

            return newCompany;
        }
    }
}
