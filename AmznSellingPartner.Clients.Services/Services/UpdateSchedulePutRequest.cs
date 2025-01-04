namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

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
		public string ResourceId { get; set; }

		/// <summary>
		/// Schedule details
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public UpdateScheduleRequest Body { get; set; }

		/// <summary>
		/// An identifier for the marketplace in which the resource operates.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; }
	}
}
