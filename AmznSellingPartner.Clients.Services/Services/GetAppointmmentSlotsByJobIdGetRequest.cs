namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/service/v1/serviceJobs/{serviceJobId}/appointmentSlots")]
	public class GetAppointmmentSlotsByJobIdGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// A service job identifier to retrive appointment slots for associated service.
		/// </summary>
		[InPath("serviceJobId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		public string ServiceJobId { get; set; } 

		/// <summary>
		/// An identifier for the marketplace in which the resource operates.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; } 

		/// <summary>
		/// A time from which the appointment slots will be retrieved. The specified time must be in ISO 8601 format.
		/// If `startTime` is provided, `endTime` should also be provided. Default value is as per business conf
		/// iguration.
		/// </summary>
		[InQuery("startTime")]
		public string StartTime { get; set; } 

		/// <summary>
		/// A time up to which the appointment slots will be retrieved. The specified time must be in ISO 8601 format.
		/// If `endTime` is provided, `startTime` should also be provided. Default value is as per business configuration.
		/// Maximum range of appointment slots can be 90 days.
		/// </summary>
		[InQuery("endTime")]
		public string EndTime { get; set; } 
	}
}
