namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// Details about the estimated delivery window.
	/// </summary>
	public class ShipmentSchedule : BaseClass
	{
		/// <summary>
		/// Date on which the shipment is expected to reach the customer delivery location. Values are
		/// in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format, with
		/// UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2020-07-16T23:00:00+01:0
		/// 0.
		/// </summary>
		[JsonProperty("estimatedDeliveryDateTime")]
		public DateTimeValue EstimatedDeliveryDateTime { get; set; } 

		/// <summary>
		/// The date and time at the start of the appointment window when the shipment is expected to be
		/// delivered. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date-time format, with UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2
		/// 020-07-16T23:00:00+01:00.
		/// </summary>
		[JsonProperty("apptWindowStartDateTime")]
		public DateTimeValue ApptWindowStartDateTime { get; set; } 

		/// <summary>
		/// The date and time at the end of the appointment window when the shipment is expected to be
		/// delivered. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date-time format, with UTC time zone or UTC offset. For example, 2020-07-16T23:00:00Z or 2
		/// 020-07-16T23:00:00+01:00.
		/// </summary>
		[JsonProperty("apptWindowEndDateTime")]
		public DateTimeValue ApptWindowEndDateTime { get; set; } 
	}
}
