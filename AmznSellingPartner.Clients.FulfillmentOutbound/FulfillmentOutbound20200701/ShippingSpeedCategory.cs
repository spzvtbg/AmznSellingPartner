namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The shipping method used for the fulfillment order
	/// When this value is `ScheduledDelivery`, choose `Ship` for the `fulfillmentAction`
	/// `Hold` is not a valid `fulfillmentAction` value when the `shippingSpeedCategory` value is `ScheduledDelivery`
	/// Note: Shipping method service level agreements vary by marketplace
	/// Sellers should refer to the [Seller Central](https://developer-docs
	/// amazon
	/// com/sp-api/docs/seller-central-urls) website in their marketplace for shipping method service level agreements
	/// and fulfillment fees
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShippingSpeedCategory
	{
		/// <summary>
		/// Standard shipping method
		/// </summary>
		[EnumMember(Value = "Standard")]
		Standard,

		/// <summary>
		/// Expedited shipping method
		/// </summary>
		[EnumMember(Value = "Expedited")]
		Expedited,

		/// <summary>
		/// Priority shipping method
		/// </summary>
		[EnumMember(Value = "Priority")]
		Priority,

		/// <summary>
		/// Scheduled Delivery shipping method
		/// This is only available in the JP marketplace
		/// </summary>
		[EnumMember(Value = "ScheduledDelivery")]
		ScheduledDelivery,
	}
}
