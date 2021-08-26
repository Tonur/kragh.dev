using System;
using System.Threading.Tasks;
using Kragh.Blazor.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Kragh.Blazor
{
	public static class Program
	{

		public static async Task Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();
			builder.Services.AddServerSideBlazor();
			builder.Services.AddScoped(sp =>
			{
				var navigationManager = sp.GetRequiredService<NavigationManager>();
				return new ClientConfiguration
				{
					BaseAddress = new Uri(@"https://localhost:8081")//navigationManager.BaseUri)
				};
			});


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseStaticFiles();

			app.UseRouting();


			app.MapBlazorHub();
			app.MapFallbackToPage("/_Host");

			await app.RunAsync();
		}
	}
}