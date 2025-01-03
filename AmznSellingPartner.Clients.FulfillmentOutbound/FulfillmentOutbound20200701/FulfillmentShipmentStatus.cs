namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum FulfillmentShipmentStatus
	{
		/// <summary>
		/// The process of picking units from inventory has begun
		/// </summary>
		[EnumMember(Value = "PENDING")]
		PENDING,

		/// <summary>
		/// All packages in the shipment have left the fulfillment center
		/// </summary>
		[EnumMember(Value = "SHIPPED")]
		SHIPPED,

		/// <summary>
		/// The Amazon fulfillment center could not fulfill the shipment as planned
		/// This might be because the inventory was not at the expected location in the fulfillment center
		/// After cancelling the fulfillment order, Amazon immediately creates a new fulfillment shipment and again attem
		/// ts to fulfill the order
		/// </summary>
		[EnumMember(Value = "CANCELLED_BY_FULFILLER")]
		CANCELLED_BY_FULFILLER,

		/// <summary>
		/// The shipment was cancelled using the `CancelFulfillmentOrder` request
		/// </summary>
		[EnumMember(Value = "CANCELLED_BY_SELLER")]
		CANCELLED_BY_SELLER,
	}
}
