using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyCafeBusinessLayer.Interfaces;
using MyCafeBusinessLayer.Mappings.AutoMapper;
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

            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new ProductProfile());
            });
            var mapper = configuration.CreateMapper();


            services.AddSingleton(mapper);
            services.AddScoped<IUow, UnitOfWork>();
            services.AddScoped<IProductService, ProductService>();
        }
	}
}

