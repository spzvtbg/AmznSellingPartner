namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpPut("/service/v1/serviceResources/{resourceId}/schedules")]
	public class UpdateSchedulePutRequest : BaseHttpRequest
	{
		/// <summary>
		/// Resource (store) Identifier
		/// </summary>
		[InPath("resourceId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		[JsonProperty("resourceId")]
		public string ResourceId { get; set; }

		/// <summary>
		/// Schedule details
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public UpdateScheduleRequest Body { get; set; }

		/// <summary>
		/// An identifier for the marketplace in which the resource operates
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }
	}
}
