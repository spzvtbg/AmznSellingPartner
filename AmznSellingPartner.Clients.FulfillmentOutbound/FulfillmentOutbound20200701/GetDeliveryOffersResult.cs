namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// A list of delivery offers, including offer expiration, earliest and latest date and time range, and the
	/// delivery offer policy.
	/// </summary>
	public class GetDeliveryOffersResult : BaseClass
	{
		/// <summary>
		/// An array of delivery offers.
		/// </summary>
		[JsonProperty("deliveryOffers")]
		public DeliveryOffersList DeliveryOffers { get; set; }
	}
}
