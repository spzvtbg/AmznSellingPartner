namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/fba/outbound/2020-07-01/deliveryOffers")]
	public class DeliveryOffersPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// GetDeliveryOffersRequest parameter
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public GetDeliveryOffersRequest Body { get; set; }
	}
}
