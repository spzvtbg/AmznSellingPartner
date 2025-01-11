namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/service/v1/appointmentSlots")]
	public class AmznGetAppointmentSlotsRequest : BaseHttpRequest
	{
		/// <summary>
		/// ASIN associated with the service.
		/// </summary>
		[InQuery("asin")]
		[IsRequired]
		public string Asin { get; set; } 

		/// <summary>
		/// Store identifier defining the region scope to retrive appointment slots.
		/// </summary>
		[InQuery("storeId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		public string StoreId { get; set; } 

		/// <summary>
		/// An identifier for the marketplace for which appointment slots are queried
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; } 

		/// <summary>
		/// A time from which the appointment slots will be retrieved. The specified time must be in ISO
		/// 8601 format. If `startTime` is provided, `endTime` should also be provided. Default value is
		/// as per business configuration.
		/// </summary>
		[InQuery("startTime")]
		public string StartTime { get; set; } 

		/// <summary>
		/// A time up to which the appointment slots will be retrieved. The specified time must be in ISO
		/// 8601 format. If `endTime` is provided, `startTime` should also be provided. Default value is
		/// as per business configuration. Maximum range of appointment slots can be 90 days.
		/// </summary>
		[InQuery("endTime")]
		public string EndTime { get; set; } 
	}
}
