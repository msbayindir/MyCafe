using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyCafeBusinessLayer.Interfaces;
using MyCafeBusinessLayer.Services;
using MyCafeDAL.UnitOfWork;

namespace MyCafeBusinessLayer.DependencyResolvers.Microsoft
{
	public static class ServicesExtensions
	{
		public static void AddDependencies( this IServiceCollection services,string str)
        {
            services.AddDbContext<MyCafeDbContext>(opt => {

                opt.UseSqlServer(str);
            });

            services.AddScoped<IUow, UnitOfWork>();
            services.AddScoped<IProductService, ProductService>();
        }
	}
}

