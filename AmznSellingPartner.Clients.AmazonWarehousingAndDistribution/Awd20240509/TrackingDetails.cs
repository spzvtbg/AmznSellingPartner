namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Tracking details for the shipment. If using SPD transportation, this can be for each case. If not using
	/// SPD transportation, this is a single tracking entry for the entire shipment.
	/// </summary>
	public class TrackingDetails : BaseClass
	{
		/// <summary>
		/// Unique or identifying code for the carrier.
		/// </summary>
		[JsonProperty("carrierCode")]
		public CarrierCode CarrierCode { get; set; }

		/// <summary>
		/// Timestamp denoting when the shipment will be shipped Date should be in ISO 8601 format as defined by
		/// date-time.
		/// </summary>
		[IsRequired]
		[JsonProperty("shipBy")]
		public DateTime ShipBy { get; set; }

		/// <summary>
		/// The identifier that is received from transportation to uniquely identify a booking.
		/// </summary>
		[MinLength(1)]
		[JsonProperty("bookingId")]
		public string BookingId { get; set; }
	}
}
