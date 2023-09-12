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

        public IEnumerable<ProductNameWithCode> GetAllProductNames()
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

        public IEnumerable<ProductInfoDatatableDto> GetProductInfoDto()
            => _dispoContext.Products
                            .Select(s => new ProductInfoDatatableDto()
                            {
                                Id = s.Id,
                                Name = s.Name,
                                PurchasePrice = s.PurchasePrice.ConverterParaReal(),
                                SalePrice = s.SalePrice.ConverterParaReal(),
                                Category = EnumExtension.ConvertToString(s.Category),
                                UnitOfMeasurement = EnumExtension.ConvertToString(s.UnitOfMeasurement),
                            })
                            .ToList();

        // ------------------

        public IEnumerable<PurchaseOrderInfoDto> GetPurchaseOrderInfoDto()
            => _dispoContext.Orders.Include(x => x.PurchaseOrder).ThenInclude(x => x.Supplier)
                                   .Select(s => new PurchaseOrderInfoDto()
                                   {
                                       IdOrder = s.Id,
                                       PurchaseOrderNumber = s.PurchaseOrder.Number,
                                       PurchaseOrderDate = s.PurchaseOrder.CreationDate,
                                       PurchaseOrderSupplierName = s.PurchaseOrder.Supplier.Name,
                                       OrderQuantity = s.Quantity
                                   })
                                   .ToList();
    }
}