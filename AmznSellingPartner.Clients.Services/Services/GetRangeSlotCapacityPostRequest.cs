namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpPost("/service/v1/serviceResources/{resourceId}/capacity/range")]
	public class GetRangeSlotCapacityPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Resource Identifier.
		/// </summary>
		[InPath("resourceId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		[JsonProperty("resourceId")]
		public string ResourceId { get; set; }

		/// <summary>
		/// Request body.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public RangeSlotCapacityQuery Body { get; set; }

		/// <summary>
		/// An identifier for the marketplace in which the resource operates.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// Next page token returned in the response of your previous request.
		/// </summary>
		[InQuery("nextPageToken")]
		[JsonProperty("nextPageToken")]
		public string NextPageToken { get; set; }
	}
}
