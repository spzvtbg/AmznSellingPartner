namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The Amazon fulfillment center address and warehouse ID.
	/// </summary>
	public class ShipmentDestination : BaseClass
	{
		/// <summary>
		/// The address the shipment should be sent to. Empty if the destination type is `AMAZON_OPTIMIZED`.
		/// </summary>
		[JsonProperty("address")]
		public Address Address { get; set; }

		/// <summary>
		/// The type of destination for this shipment. Possible values: `AMAZON_OPTIMIZED`, `AMAZON_WAREHOUSE`.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("destinationType")]
		public string DestinationType { get; set; }

		/// <summary>
		/// The warehouse that the shipment should be sent to. Empty if the destination type is `AMAZON_OPTIMIZE
		/// D`.
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("warehouseId")]
		public string WarehouseId { get; set; }
	}
}
