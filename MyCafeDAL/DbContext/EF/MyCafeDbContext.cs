using System;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using MyCafeDAL.Concrete.EF.Config;

public class MyCafeDbContext:DbContext
{

    public MyCafeDbContext(DbContextOptions<MyCafeDbContext> options):base(options)
    {
        
    }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     

       modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
    }


        
   }


