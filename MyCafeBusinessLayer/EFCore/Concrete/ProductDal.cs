using System;
using MyCafeBusinessLayer.EFCore.Abstract;
using MyCafeDAL.Entities;

namespace MyCafeBusinessLayer.EFCore.Concrete
{
	public class ProductDal:BaseRepostory<Product>,IEntityRepostory<Product>,IProductDal
	{
		public ProductDal()
		{
		}
	}
}

