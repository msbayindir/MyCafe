using System;
using Microsoft.EntityFrameworkCore;
using MyCafeDAL.Concrete.EF.Config;
using MyCafeDAL.Entities;



	public class MyCafeDbContext:DbContext
	{
       
            public DbSet<Product> Products { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=MyCafe;User=sa;Password=MyPass@word");
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new ProductConfig());

                //modelBuilder.ApplyConfiguration(new BookAuthorConfig());
                //modelBuilder.ApplyConfiguration(new BookConfig());
                //modelBuilder.ApplyConfiguration(new BookDetailConfig());
                //modelBuilder.ApplyConfiguration(new CategoryConfig());
                // modelBuilder.ApplyConfigurationsFromAssembly(typeof(AuthorConfig).Assembly);

                //modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            }


        
    }


