namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The shipment status to apply.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShipmentStatus
	{
		/// <summary>
		/// Ready for pickup.
		/// </summary>
		[EnumMember(Value = "ReadyForPickup")]
		ReadyForPickup,

		/// <summary>
		/// Picked up.
		/// </summary>
		[EnumMember(Value = "PickedUp")]
		PickedUp,

		/// <summary>
		/// Refused pickup.
		/// </summary>
		[EnumMember(Value = "RefusedPickup")]
		RefusedPickup,
	}
}
