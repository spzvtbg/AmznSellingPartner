namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The product details for the delivery offer.
	/// </summary>
	public class GetDeliveryOffersProduct : BaseClass
	{
		/// <summary>
		/// Product identifier input that locates a product for MCF.
		/// </summary>
		[JsonProperty("productIdentifier")]
		[IsRequired]
		public ProductIdentifier ProductIdentifier { get; set; } 

		/// <summary>
		/// The amount of the requested product.
		/// </summary>
		[JsonProperty("amount")]
		public Amount Amount { get; set; } 
	}
}
