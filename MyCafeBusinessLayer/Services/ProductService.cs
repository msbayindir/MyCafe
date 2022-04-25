using System;
using AutoMapper;
using Entites.Concrete;
using MyCafe.Dtos.ProductDtos;
using MyCafeBusinessLayer.Interfaces;
using MyCafeDAL.UnitOfWork;

namespace MyCafeBusinessLayer.Services
{
	public class ProductService:IProductService
	{

        private readonly IUow _uow;
        private readonly IMapper _mapper;

        public ProductService(IUow uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task Add(ProductAddDto entity)
        {
            await _uow.GetRepository<Product>().Add(_mapper.Map<Product>(entity));
            await _uow.SaveChanges();
        }

        public async Task AddWithList(List<ProductListDto> entities)
        {

            await _uow.GetRepository<Product>().AddWithList(_mapper.Map<List<Product>>(entities));
            await _uow.SaveChanges();
        }

        public async Task<List<ProductListDto>> GetAll()
        {
            

            //var productList = new List<ProductListDto>();
            //if(list!=null && list.Count > 0)
            //{
            //    foreach (var product in list)
            //    {
            //        productList.Add(new()
            //        {
            //            Id = product.Id,
            //            ProductName = product.ProductName,
            //            Price = product.Price,
            //            ProductImage = product.ProductImage,
            //            ImageUrl = product.ImageUrl
            //        });
            //    }
            //}
            return _mapper.Map<List<ProductListDto>>(await _uow.GetRepository<Product>().GetAll());
        }

        public async Task<ProductListDto> GetById(object id)
        {

            return _mapper.Map<ProductListDto>(await _uow.GetRepository<Product>().GetByFilter(p=>p.Id==(int)id));
        }

        public async Task Remove(object id)
        {

            var removeItem = await _uow.GetRepository<Product>().GetSingle(id);
            _uow.GetRepository<Product>().Remove(removeItem);
            await _uow.SaveChanges();

        }

        public async Task Update(ProductListDto entity)
        {
            _uow.GetRepository<Product>().Update(_mapper.Map<Product>(entity));
           await _uow.SaveChanges();
        }
    }
}

