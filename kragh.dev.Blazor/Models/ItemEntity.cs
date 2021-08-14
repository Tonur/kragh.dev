using System;
#nullable disable

namespace kragh.dev.Blazor.Models
{
	public class ItemEntity
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Location { get; set; }
		public DateTime StartsAt { get; set; }
		public DateTime? EndsAt { get; set; }
	}
}