namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// Input for fulfillment time details
	/// </summary>
	public class FulfillmentTime : BaseClass
	{
		/// <summary>
		/// The date, time in UTC of the fulfillment start time in ISO 8601 format.
		/// </summary>
		[JsonProperty("startTime")]
		public DateTimeValue StartTime { get; set; } 

		/// <summary>
		/// The date, time in UTC of the fulfillment end time in ISO 8601 format.
		/// </summary>
		[JsonProperty("endTime")]
		public DateTimeValue EndTime { get; set; } 
	}
}
