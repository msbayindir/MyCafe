using System;
using System.ComponentModel.DataAnnotations;

namespace MyCafe.Dtos.ProductDtos
{
	public class ProductAddDto
	{
		
		public string ProductName { get; set; }

		public double Price { get; set; }
		
		public byte[]? ProductImage { get; set; }

		public string? ImageUrl { get; set; }
	}
}

