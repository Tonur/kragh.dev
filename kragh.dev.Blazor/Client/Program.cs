using kragh.dev.Blazor.Client.Config;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace kragh.dev.Blazor.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddScoped(sp => new ClientConfiguration { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress.TrimEnd('/') + ":5001") });

			await builder.Build().RunAsync();
		}
	}
}
