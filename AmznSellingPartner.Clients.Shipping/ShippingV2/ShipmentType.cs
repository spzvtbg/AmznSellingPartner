namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Shipment type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShipmentType
	{
		/// <summary>
		/// The identifier for forward request.
		/// </summary>
		[EnumMember(Value = "FORWARD")]
		FORWARD,

		/// <summary>
		/// The identifier for return request.
		/// </summary>
		[EnumMember(Value = "RETURNS")]
		RETURNS,
	}
}
