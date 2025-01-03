namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Indicates whether the additional seller input is at the item or shipment level.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InputTargetType
	{
		/// <summary>
		/// The additional seller input is at the shipment level.
		/// </summary>
		[EnumMember(Value = "SHIPMENT_LEVEL")]
		SHIPMENT_LEVEL,

		/// <summary>
		/// The additional seller input is at the item level.
		/// </summary>
		[EnumMember(Value = "ITEM_LEVEL")]
		ITEM_LEVEL,
	}
}
