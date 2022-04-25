
using AutoMapper;
using Entites.Concrete;
using MyCafe.Dtos.ProductDtos;

namespace MyCafeBusinessLayer.Mappings.AutoMapper
{
	public class ProductProfile:Profile
	{
		public ProductProfile()
		{
			CreateMap<Product, ProductListDto>().ReverseMap();
			CreateMap<Product, ProductAddDto>().ReverseMap();
			
		}
	}
}

