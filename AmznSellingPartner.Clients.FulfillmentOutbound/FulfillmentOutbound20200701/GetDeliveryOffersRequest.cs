namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request body schema for the getDeliveryOffers operation.
	/// </summary>
	public class GetDeliveryOffersRequest : BaseClass
	{
		/// <summary>
		/// The product details for the delivery offer.
		/// </summary>
		[JsonProperty("product")]
		[IsRequired]
		public GetDeliveryOffersProduct Product { get; set; }

		/// <summary>
		/// The terms for the delivery offer.
		/// </summary>
		[JsonProperty("terms")]
		[IsRequired]
		public GetDeliveryOffersTerms Terms { get; set; }
	}
}
