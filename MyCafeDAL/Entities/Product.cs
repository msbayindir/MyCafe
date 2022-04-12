using System;
using MyCafeDAL.ImageConverter;

namespace MyCafeDAL.Entities
{
	public class Product:ImageCon
	{
        
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public byte[] ProductImage { get; set; }



       

        






    }
}

