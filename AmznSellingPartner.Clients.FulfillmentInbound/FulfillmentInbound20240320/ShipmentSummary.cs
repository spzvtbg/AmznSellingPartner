namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Summary information about a shipment.
	/// </summary>
	public class ShipmentSummary : BaseClass
	{
		/// <summary>
		/// Identifier of a shipment. A shipment contains the boxes and units being inbounded.
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("shipmentId")]
		public string ShipmentId { get; set; }

		/// <summary>
		/// The status of a shipment. The state of the shipment will typically start as `UNCONFIRMED`, then transition
		/// to `WORKING` after a placement option has been confirmed, and then to `READY_TO_SHIP` once labels are
		/// generated.  Possible values: `ABANDONED`, `CANCELLED`, `CHECKED_IN`, `CLOSED`, `DELETED`, `DELIVERED`,
		/// `IN_TRANSIT`, `MIXED`, `READY_TO_SHIP`, `RECEIVING`, `SHIPPED`, `UNCONFIRMED`, `WORKING`
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}
