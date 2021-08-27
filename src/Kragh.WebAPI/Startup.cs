using Kragh.WebAPI.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Kragh.WebAPI
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddDefaultPolicy(builder =>
				{
					builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
				});
			});

			services.AddSwaggerGen();

			services.AddControllersWithViews();
			services.AddRazorPages();

			services.AddSingleton(_ =>
			{
				KraghConfiguration config = new();
				Configuration.Bind("KraghConfiguration", config);
				return config;
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseSwaggerUI();

			app.UseCors();

			app.UseSwaggerUI();

			app.UseHttpsRedirection();

			app.UseStaticFiles();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapRazorPages();
				endpoints.MapControllers();
				endpoints.MapFallbackToFile("index.html");
			});
		}
	}
}
