namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// Contains details for a transportation carrier appointment. This appointment is vended out by Amazon and
	/// is an indicator for when a transportation carrier is accepting shipments to be picked up.
	/// </summary>
	public class CarrierAppointment : BaseClass
	{
		/// <summary>
		/// The end timestamp of the appointment in UTC.
		/// </summary>
		[JsonProperty("endTime")]
		[IsRequired]
		public DateTimeValue EndTime { get; set; } 

		/// <summary>
		/// The start timestamp of the appointment in UTC.
		/// </summary>
		[JsonProperty("startTime")]
		[IsRequired]
		public DateTimeValue StartTime { get; set; } 
	}
}
