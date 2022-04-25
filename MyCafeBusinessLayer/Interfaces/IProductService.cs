using System;
using MyCafe.Dtos.ProductDtos;

namespace MyCafeBusinessLayer.Interfaces
{
	public interface IProductService
	{
		Task<List<ProductListDto>> GetAll();
		Task Add(ProductAddDto entity);
		Task<ProductListDto>GetById(object id);
		Task Remove(ProductListDto entity);
		Task Update(ProductListDto entity);
		Task AddWithParams(params ProductListDto[] entity);
	}
}

