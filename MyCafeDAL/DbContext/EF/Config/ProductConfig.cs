using System;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MyCafeDAL.Concrete.EF.Config
{
	public class ProductConfig:IEntityTypeConfiguration<Product>
	{
		

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ProductName).HasMaxLength(25);
            builder.Property(p => p.ImageUrl).IsRequired(false);
            builder.Property(p => p.ProductImage).IsRequired(false);




        }
    }
}

