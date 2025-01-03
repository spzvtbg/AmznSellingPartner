namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShippingOptionType
	{
		/// <summary>
		/// The estimated shipping cost of the product
		/// Note that the shipping cost is not always available
		/// </summary>
		[EnumMember(Value = "DEFAULT")]
		DEFAULT,
	}
}
