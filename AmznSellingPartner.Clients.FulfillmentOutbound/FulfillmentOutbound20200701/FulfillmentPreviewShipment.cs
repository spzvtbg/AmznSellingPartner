namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Delivery and item information for a shipment in a fulfillment order preview.
	/// </summary>
	public class FulfillmentPreviewShipment : BaseClass
	{
		/// <summary>
		/// The earliest date that the shipment is expected to be sent from the fulfillment center. Must be in <a
		/// href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO 8601</a> format.
		/// </summary>
		[JsonProperty("earliestShipDate")]
		public Timestamp EarliestShipDate { get; set; }

		/// <summary>
		/// The latest date that the shipment is expected to be sent from the fulfillment center. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[JsonProperty("latestShipDate")]
		public Timestamp LatestShipDate { get; set; }

		/// <summary>
		/// The earliest date that the shipment is expected to arrive at its destination.
		/// </summary>
		[JsonProperty("earliestArrivalDate")]
		public Timestamp EarliestArrivalDate { get; set; }

		/// <summary>
		/// The latest date that the shipment is expected to arrive at its destination. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[JsonProperty("latestArrivalDate")]
		public Timestamp LatestArrivalDate { get; set; }

		/// <summary>
		/// Provides additional insight into the shipment timeline when exact delivery dates are not able to be
		/// precomputed.
		/// </summary>
		[JsonProperty("shippingNotes")]
		public List<string> ShippingNotes { get; set; }

		/// <summary>
		/// Information about the items in the shipment.
		/// </summary>
		[JsonProperty("fulfillmentPreviewItems")]
		[IsRequired]
		public FulfillmentPreviewItemList FulfillmentPreviewItems { get; set; }
	}
}
