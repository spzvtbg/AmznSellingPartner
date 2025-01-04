namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Item identifiers for an item in a direct fulfillment shipment.
	/// </summary>
	public class DirectFulfillmentItemIdentifiers : BaseClass
	{
		/// <summary>
		/// A unique identifier for an item provided by the client for a direct fulfillment shipment. This is only
		/// populated for direct fulfillment multi-piece shipments. It is required if a vendor wants to change the
		/// configuration of the packages in which the purchase order is shipped.
		/// </summary>
		[JsonProperty("lineItemID")]
		[IsRequired]
		public string LineItemID { get; set; }

		/// <summary>
		/// A unique identifier for an item provided by the client for a direct fulfillment shipment. This is only
		/// populated if a single line item has multiple pieces. Defaults to 1.
		/// </summary>
		[JsonProperty("pieceNumber")]
		public string PieceNumber { get; set; }
	}
}
