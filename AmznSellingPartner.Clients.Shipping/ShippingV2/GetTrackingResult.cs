namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// The payload for the getTracking operation
	/// </summary>
	public class GetTrackingResult : BaseClass
	{
		[IsRequired]
		[JsonProperty("trackingId")]
		public TrackingId TrackingId { get; set; }

		[IsRequired]
		[JsonProperty("alternateLegTrackingId")]
		public AlternateLegTrackingId AlternateLegTrackingId { get; set; }

		/// <summary>
		/// A list of tracking events
		/// </summary>
		[IsRequired]
		[JsonProperty("eventHistory")]
		public List<Event> EventHistory { get; set; }

		/// <summary>
		/// The date and time by which the shipment is promised to be delivered
		/// </summary>
		[IsRequired]
		[JsonProperty("promisedDeliveryDate")]
		public DateTime PromisedDeliveryDate { get; set; }

		[IsRequired]
		[JsonProperty("summary")]
		public TrackingSummary Summary { get; set; }
	}
}
