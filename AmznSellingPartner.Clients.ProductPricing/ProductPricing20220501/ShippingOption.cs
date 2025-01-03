namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The shipping option available for the offer
	/// </summary>
	public class ShippingOption : BaseClass
	{
		/// <summary>
		/// The type of shipping option
		/// </summary>
		[IsRequired]
		[JsonProperty("shippingOptionType")]
		public ShippingOptionType ShippingOptionType { get; set; }

		/// <summary>
		/// Shipping price for the offer
		/// </summary>
		[IsRequired]
		[JsonProperty("price")]
		public MoneyType Price { get; set; }
	}
}
