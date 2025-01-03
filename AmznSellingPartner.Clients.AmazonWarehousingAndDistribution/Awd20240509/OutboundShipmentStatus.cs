namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Possible shipment statuses for outbound shipments.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OutboundShipmentStatus
	{
		/// <summary>
		/// Shipment is created. No inventory has been picked up at the source node.
		/// </summary>
		[EnumMember(Value = "CREATED")]
		CREATED,

		/// <summary>
		/// Carrier acknowledged that the shipment is in transit between the origin node and destination node.
		/// </summary>
		[EnumMember(Value = "IN_TRANSIT")]
		IN_TRANSIT,

		/// <summary>
		/// Carrier indicated that the shipment has arrived at the destination node, but the destination node has not ackn
		/// wledged the delivery.
		/// </summary>
		[EnumMember(Value = "DELIVERED")]
		DELIVERED,

		/// <summary>
		/// Destination node acknowledged the arrival of the shipment.
		/// </summary>
		[EnumMember(Value = "RECEIVING")]
		RECEIVING,

		/// <summary>
		/// Destination node has received the items.
		/// </summary>
		[EnumMember(Value = "RECEIVED")]
		RECEIVED,

		/// <summary>
		/// No more actions are required for the shipment. This is a final state.
		/// </summary>
		[EnumMember(Value = "CLOSED")]
		CLOSED,

		/// <summary>
		/// Shipment has been cancelled by order owner. This is a final state.
		/// </summary>
		[EnumMember(Value = "CANCELLED")]
		CANCELLED,

		/// <summary>
		/// Shipment delivery has failed. This is a final state.
		/// </summary>
		[EnumMember(Value = "FAILED")]
		FAILED,
	}
}
