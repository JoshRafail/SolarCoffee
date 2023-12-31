﻿using SolarCoffee.Data;
using SolarCoffee.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarCoffee.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly SolarDbContext _db;

        public ProductService(SolarDbContext dbContext)
        {
            _db = dbContext;
        }

        /// <summary>
        /// Retrieves all Product from database
        /// </summary>
        /// <returns></returns>
        List<Data.Models.Product> IProductService.GetAllProducts()
        {
            return _db.Products.ToList();
        }

        /// <summary>
        /// Retrieves a Product by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Data.Models.Product IProductService.GetProductById(int id)
        {
            return _db.Products.Find(id);
        }

        /// <summary>
        /// Adds a new product to the database
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        ServiceResponse<Data.Models.Product> IProductService.CreateProduct(Data.Models.Product product)
        {
            try
            {
                _db.Products.Add(product);

                var newInventory = new ProductInventory
                {
                    Product = product,
                    QuantityOnHand = 0,
                    IdealQuantity = 10,
                };

                _db.ProductInventories.Add(newInventory);

                _db.SaveChanges();

                return new ServiceResponse<Data.Models.Product>
                {
                    Data = product,
                    Time = DateTime.UtcNow,
                    Message = "Saved new Product",
                    IsSuccess = true
                };
            }
            catch(Exception ex)
            {
                return new ServiceResponse<Data.Models.Product>
                {
                    Data = product,
                    Time = DateTime.UtcNow,
                    Message = ex.StackTrace,
                    IsSuccess = false
                };
            }
        }

        /// <summary>
        /// Archive a Product by setting boolean IsArchived to true
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        ServiceResponse<Data.Models.Product> IProductService.ArchiveProduct(int id)
        {
            try
            {
                var product = _db.Products.Find(id);
                product.IsArchived = true;
                _db.SaveChanges();

                return new ServiceResponse<Data.Models.Product>
                {
                    Data = product,
                    Time = DateTime.UtcNow,
                    Message = "Archived Product",
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Data.Models.Product>
                {
                    Data = null,
                    Time = DateTime.UtcNow,
                    Message = ex.StackTrace,
                    IsSuccess = false
                };
            }
        }

    }
}
