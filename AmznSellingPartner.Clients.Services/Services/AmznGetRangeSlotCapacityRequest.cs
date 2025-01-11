namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpPost("/service/v1/serviceResources/{resourceId}/capacity/range")]
	public class AmznGetRangeSlotCapacityRequest : BaseHttpRequest
	{
		/// <summary>
		/// Resource Identifier.
		/// </summary>
		[InPath("resourceId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		public string ResourceId { get; set; } 

		/// <summary>
		/// Request body.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public RangeSlotCapacityQuery Body { get; set; } 

		/// <summary>
		/// An identifier for the marketplace in which the resource operates.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; } 

		/// <summary>
		/// Next page token returned in the response of your previous request.
		/// </summary>
		[InQuery("nextPageToken")]
		public string NextPageToken { get; set; } 
	}
}
