namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the getDeliveryOffers operation.
	/// </summary>
	public class GetDeliveryOffersResponse : BaseClass
	{
		/// <summary>
		/// The response payload for the getDeliveryOffers operation.
		/// </summary>
		[JsonProperty("payload")]
		public GetDeliveryOffersResult Payload { get; set; } 

		/// <summary>
		/// One or more unexpected errors occurred during the getDeliveryOffers operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
