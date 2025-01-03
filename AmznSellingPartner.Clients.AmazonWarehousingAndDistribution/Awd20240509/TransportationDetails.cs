namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Transportation details for the shipment.
	/// </summary>
	public class TransportationDetails : BaseClass
	{
		/// <summary>
		/// Tracking details for the shipment. If using SPD transportation, this can be for each case. If not using SPD tr
		/// nsportation, this is a single tracking entry for the entire shipment.
		/// </summary>
		[IsRequired]
		[JsonProperty("trackingDetails")]
		public List<TrackingDetails> TrackingDetails { get; set; }
	}
}
