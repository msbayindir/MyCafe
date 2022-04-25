using System;
namespace MyCafe.Dtos.ProductDtos
{
	public class ProductListDto
	{
		public int Id { get; set; }

		public string ProductName { get; set; }

		public double Price { get; set; }

		public byte[]? ProductImage { get; set; }

		public string? ImageUrl { get; set; }
	}
}

