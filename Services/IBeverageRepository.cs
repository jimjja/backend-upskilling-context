﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ShalekKavy.Api.Services
{
    public interface IBeverageRepository
    {
        public Task<List<Beverage>> GetAll();
        public Task<Beverage> GetById(string id);
        public Task<Beverage> GetByBeverageName(string name);
        public Task<List<Beverage>> GetByBeverageType(BeverageType type);
        public Task AddBeverage(Beverage beverage);
        public Task UpdateBeverage(Beverage existingBeverage, Beverage updatedBeverage);
        public Task DeleteBeverage(Beverage beverage);
    }
}