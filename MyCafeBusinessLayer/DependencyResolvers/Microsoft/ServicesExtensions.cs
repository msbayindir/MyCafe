using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MyCafeBusinessLayer.DependencyResolvers.Microsoft
{
	public static class ServicesExtensions
	{
		public static void AddDependencies( this IServiceCollection services,string str)
        {
            services.AddDbContext<MyCafeDbContext>(opt => {

                opt.UseSqlServer(str);
            });
        }
	}
}

