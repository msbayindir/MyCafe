using System;
using Entites.Concrete;
using MyCafe.Dtos.ProductDtos;
using MyCafeBusinessLayer.Interfaces;
using MyCafeDAL.UnitOfWork;

namespace MyCafeBusinessLayer.Services
{
	public class ProductService:IProductService
	{

        private readonly IUow _uow;
        public ProductService(IUow uow)
        {
            _uow = uow;
        }

        public async Task Add(ProductAddDto entity)
        {
            await _uow.GetRepository<Product>().Add(new()
            {
                ProductName = entity.ProductName,
                Price = entity.Price,
                ProductImage = entity.ProductImage,
                ImageUrl = entity.ImageUrl
            });
            _uow.SaveChanges();
        }

        public async Task AddWithParams(params ProductListDto[] entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductListDto>> GetAll()
        {
            var list =  await _uow.GetRepository<Product>().GetAll();
            
            var productList = new List<ProductListDto>();
            if(list!=null && list.Count > 0)
            {
                foreach (var product in list)
                {
                    productList.Add(new()
                    {
                        Id = product.Id,
                        ProductName = product.ProductName,
                        Price = product.Price,
                        ProductImage = product.ProductImage,
                        ImageUrl = product.ImageUrl
                    });
                }
            }
            return productList;
        }

        public async Task<ProductListDto> GetById(object id)
        {
            var product = await _uow.GetRepository<Product>().GetSingle(id);
            ProductListDto productDto = new ProductListDto
            {
                Id = product.Id,
                Price = product.Price,
                ProductName = product.ProductName,
                ProductImage = product.ProductImage,
                ImageUrl = product.ImageUrl

            };

            return productDto;
        }

        public async Task Remove(ProductListDto entity)
        {
             _uow.GetRepository<Product>().Remove(new()
            {
                Id = entity.Id,
                ProductName = entity.ProductName,
                Price = entity.Price,
                ProductImage = entity.ProductImage,
                ImageUrl = entity.ImageUrl

            });
           await _uow.SaveChanges();

        }

        public async Task Update(ProductListDto entity)
        {
            _uow.GetRepository<Product>().Update(new()
            {
                Id = entity.Id,
                ProductName = entity.ProductName,
                Price = entity.Price,
                ProductImage = entity.ProductImage,
                ImageUrl = entity.ImageUrl

            });
           await _uow.SaveChanges();
        }
    }
}

