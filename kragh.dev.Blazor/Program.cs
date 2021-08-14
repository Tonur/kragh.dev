using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using kragh.dev.Blazor.Models;

namespace kragh.dev.Blazor
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddCors(options =>
				options.AddDefaultPolicy(policyBuilder =>
				{
					policyBuilder
						.AllowAnyOrigin()
						.AllowAnyMethod()
						.AllowAnyHeader();
				}));

			builder.Services.AddSingleton(_ =>
			{
				KraghConfiguration config = new();
				builder.Configuration.Bind("KraghConfiguration", config);
				return config;
			});

			await builder.Build().RunAsync();
		}
	}
}
