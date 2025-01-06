namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// The `generateSelfShipAppointmentSlots` request.
	/// </summary>
	public class GenerateSelfShipAppointmentSlotsRequest : BaseClass
	{
		/// <summary>
		/// The desired end date. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime
		/// format.
		/// </summary>
		[JsonProperty("desiredEndDate")]
		public DateTimeValue DesiredEndDate { get; set; } 

		/// <summary>
		/// The desired start date. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime
		/// format.
		/// </summary>
		[JsonProperty("desiredStartDate")]
		public DateTimeValue DesiredStartDate { get; set; } 
	}
}
