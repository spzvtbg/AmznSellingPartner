namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Possible shipment statuses used by shipments.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InboundShipmentStatus
	{
		/// <summary>
		/// Shipment is created but has not yet shipped.
		/// </summary>
		[EnumMember(Value = "CREATED")]
		CREATED,

		/// <summary>
		/// Shipment was picked up by the carrier or was dropped off with the carrier.
		/// </summary>
		[EnumMember(Value = "SHIPPED")]
		SHIPPED,

		/// <summary>
		/// The carrier has notified AWD that the shipment is in transit between origin and destination node.
		/// </summary>
		[EnumMember(Value = "IN_TRANSIT")]
		IN_TRANSIT,

		/// <summary>
		/// The shipment has been partially received.
		/// </summary>
		[EnumMember(Value = "RECEIVING")]
		RECEIVING,

		/// <summary>
		/// The shipment has reached the destination node and has been delivered to the facility yard. The shipment
		/// receive process at the warehouse will start soon.
		/// </summary>
		[EnumMember(Value = "DELIVERED")]
		DELIVERED,

		/// <summary>
		/// No more actions required on the shipment. This is a final state.
		/// </summary>
		[EnumMember(Value = "CLOSED")]
		CLOSED,

		/// <summary>
		/// Shipment has been cancelled. This is a final state.
		/// </summary>
		[EnumMember(Value = "CANCELLED")]
		CANCELLED,
	}
}
