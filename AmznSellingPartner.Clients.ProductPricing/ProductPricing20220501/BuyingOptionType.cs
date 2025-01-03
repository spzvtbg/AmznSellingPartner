namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum BuyingOptionType
	{
		/// <summary>
		/// New
		/// </summary>
		[EnumMember(Value = "New")]
		New,
	}
}
