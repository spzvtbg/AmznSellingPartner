namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Payment type of the purchase
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PaymentType
	{
		/// <summary>
		/// Payment Through Amazon
		/// </summary>
		[EnumMember(Value = "PAY_THROUGH_AMAZON")]
		PAY_THROUGH_AMAZON,

		/// <summary>
		/// Payment Direct to Carrier
		/// </summary>
		[EnumMember(Value = "PAY_DIRECT_TO_CARRIER")]
		PAY_DIRECT_TO_CARRIER,
	}
}
