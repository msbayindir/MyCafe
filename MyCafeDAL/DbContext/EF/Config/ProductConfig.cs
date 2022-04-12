using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCafeDAL.Entities;

namespace MyCafeDAL.Concrete.EF.Config
{
	public class ProductConfig:IEntityTypeConfiguration<Product>
	{
		

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
           

        }
    }
}

