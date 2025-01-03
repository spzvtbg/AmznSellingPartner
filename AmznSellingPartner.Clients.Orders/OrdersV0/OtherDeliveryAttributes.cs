namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Miscellaneous delivery attributes associated with the shipping address
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OtherDeliveryAttributes
	{
		/// <summary>
		/// Indicates whether the delivery has an access point pickup or drop-off location
		/// </summary>
		[EnumMember(Value = "HAS_ACCESS_POINT")]
		HAS_ACCESS_POINT,

		/// <summary>
		/// Indicates whether pallet delivery is enabled for the address
		/// </summary>
		[EnumMember(Value = "PALLET_ENABLED")]
		PALLET_ENABLED,

		/// <summary>
		/// Indicates whether pallet delivery is disabled for the address
		/// </summary>
		[EnumMember(Value = "PALLET_DISABLED")]
		PALLET_DISABLED,
	}
}
