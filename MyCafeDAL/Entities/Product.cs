using System;
namespace MyCafeDAL.Entities
{
	public class Product
	{
        public int Id { get; set; }

        public string? ProductName { get; set; }

        public double Price { get; set; }

        public byte[]? Image { get; set; }


       

    }
}

