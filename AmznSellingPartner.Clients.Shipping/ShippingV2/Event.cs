namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// A tracking event.
	/// </summary>
	public class Event : BaseClass
	{
		[JsonProperty("eventCode")]
		[IsRequired]
		public EventCode EventCode { get; set; } 

		[JsonProperty("location")]
		public Location Location { get; set; } 

		/// <summary>
		/// The ISO 8601 formatted timestamp of the event.
		/// </summary>
		[JsonProperty("eventTime")]
		[IsRequired]
		public DateTimeValue EventTime { get; set; } 
	}
}
