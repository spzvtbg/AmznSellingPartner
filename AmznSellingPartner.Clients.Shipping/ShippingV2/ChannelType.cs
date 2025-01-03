namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The shipment source channel type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChannelType
	{
		/// <summary>
		/// Indicates that the shipment originates from an Amazon order.
		/// </summary>
		[EnumMember(Value = "AMAZON")]
		AMAZON,

		/// <summary>
		/// Indicates that the shipment originates from a non-Amazon channel.
		/// </summary>
		[EnumMember(Value = "EXTERNAL")]
		EXTERNAL,
	}
}
