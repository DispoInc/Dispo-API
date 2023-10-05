﻿using Dispo.Commom;
using Dispo.Commom.Extensions;
using Dispo.Domain.DTO_s;
using Dispo.Domain.DTOs;
using Dispo.Domain.Entities;
using Dispo.Infrastructure.Context;
using Dispo.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Dispo.Infrastructure.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly DispoContext _dispoContext;

        public ProductRepository(DispoContext dispoContext) : base(dispoContext)
        {
            _dispoContext = dispoContext;
        }

        public IEnumerable<ProductNameWithCode> GetAllProductNamesWithCode()
            => _dispoContext.Products
                            .Select(s => new ProductNameWithCode
                            {
                                Id = s.Id,
                                Name = s.Name,
                            })
                            .Distinct()
                            .ToList();

        public long GetProductIdByName(string productName)
            => _dispoContext.Products
                            .Where(x => x.Name == productName)
                            .Select(s => s.Id)
                            .SingleOrDefault()
                            .ToLong();

        public IEnumerable<ProductInfoDto> GetProductInfoDto()
            => _dispoContext.Products
                            .Select(s => new ProductInfoDto()
                            {
                                Id = s.Id,
                                Name = s.Name,
                                PurchasePrice = s.PurchasePrice.ConverterParaReal(),
                                SalePrice = s.SalePrice.ConverterParaReal(),
                                Category = EnumExtension.ConvertToString(s.Category),
                                UnitOfMeasurement = EnumExtension.ConvertToString(s.UnitOfMeasurement),
                            })
                            .ToList();

        public List<ProductInfoDto> GetWithActivePurschaseOrder()
        {
            return _dispoContext.Products
                                .Include(i => i.Orders).ThenInclude(i => i.PurchaseOrder)
                                .Where(w => w.Orders != null && w.Orders.Any(w => w.PurchaseOrderId > 0))
                                .Select(s => new ProductInfoDto
                                {
                                    Id = s.Id,
                                    Name = s.Name
                                }).ToList();
        }

        public List<ProductExitMovementDto> GetWithSalePrice()
        {
            return _dispoContext.Products.Select(s => new ProductExitMovementDto
            {
                Id = s.Id,
                Name = s.Name,
                SalePrice = s.SalePrice
            }).ToList();
        }
    }
}