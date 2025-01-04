namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of error responses returned when a request is unsuccessful.
	/// </summary>
	public class ErrorList : BaseClass
	{
		[JsonProperty("errors")]
		[IsRequired]
		public List<Error> Errors { get; set; } 
	}
}
