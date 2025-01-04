namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The delivery terms for the delivery offer.
	/// </summary>
	public class GetDeliveryOffersTerms : BaseClass
	{
		/// <summary>
		/// The origin for the delivery offer.
		/// </summary>
		[JsonProperty("origin")]
		[IsRequired]
		public Origin Origin { get; set; }

		/// <summary>
		/// The destination for the delivery offer.
		/// </summary>
		[JsonProperty("destination")]
		[IsRequired]
		public Destination Destination { get; set; }
	}
}
