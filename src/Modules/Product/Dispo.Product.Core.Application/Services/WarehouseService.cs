﻿using Dispo.Product.Core.Application.Services.Interfaces;
using Dispo.Shared.Core.Domain.DTOs.Request;
using Dispo.Shared.Core.Domain.Entities;
using Dispo.Shared.Core.Domain.Exceptions;
using Dispo.Shared.Core.Domain.Interfaces;
using System.Transactions;

namespace Dispo.Product.Core.Application.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseRepository _warehouseRepository;

        public WarehouseService(IWarehouseRepository warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
        }

        public void CreateWarehouse(WarehouseRequestDto warehouseRequestDto)
        {
            if (_warehouseRepository.ExistsByAddressId(warehouseRequestDto.AddressId))
                throw new AlreadyExistsException("Já existe um depósito cadastrado nesse endereço.");

            using (var tc = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var warehouse = new Warehouse
                {
                    AddressId = warehouseRequestDto.AddressId,
                    Name = warehouseRequestDto.Name,
                };

                _warehouseRepository.Create(warehouse);
                tc.Complete();
            }
        }
    }
}