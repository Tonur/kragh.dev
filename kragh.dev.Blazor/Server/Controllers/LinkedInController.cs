using System;
using System.Net;
using Flurl;
using Flurl.Http;
using kragh.dev.Blazor.Server.Configuration;
using kragh.dev.Blazor.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace kragh.dev.Blazor.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class LinkedInController : ControllerBase
	{
		private const string ProxyCurlUrl = @"https://nubela.co/proxycurl/api/v2/linkedin";
		private const string LinkedInUrl = @"https://www.linkedin.com/in/";

		private readonly ILogger<LinkedInController> _logger;
		private readonly KraghConfiguration _config;

		public LinkedInController(ILogger<LinkedInController> logger, KraghConfiguration config)
		{
			_logger = logger;
			_config = config;
		}

		[HttpGet]
		public async Task<LinkedInResponse> GetLinkedInInfo()
		{
			var response = await ProxyCurlUrl
				.AllowAnyHttpStatus()
				.WithOAuthBearerToken(_config.ProxyCurlToken)
				.SetQueryParams(new
				{
					url = LinkedInUrl.AppendPathSegment(_config.LinkedInId).ToString(),
					use_cache = "if-present",
				}).GetAsync();

			var fallback = await System.IO.File.ReadAllTextAsync("data.json");

			return response.StatusCode == (int)HttpStatusCode.OK 
				? await response.GetJsonAsync<LinkedInResponse>() 
				: JsonConvert.DeserializeObject<LinkedInResponse>(fallback)!;
		}
	}
}
