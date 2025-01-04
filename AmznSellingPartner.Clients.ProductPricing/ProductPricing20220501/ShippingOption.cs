namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The shipping option available for the offer.
	/// </summary>
	public class ShippingOption : BaseClass
	{
		/// <summary>
		/// The type of shipping option.
		/// </summary>
		[JsonProperty("shippingOptionType")]
		[IsRequired]
		public ShippingOptionType ShippingOptionType { get; set; } 

		/// <summary>
		/// Shipping price for the offer.
		/// </summary>
		[JsonProperty("price")]
		[IsRequired]
		public MoneyType Price { get; set; } 
	}
}
