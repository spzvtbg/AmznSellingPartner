namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/fba/outbound/2020-07-01/fulfillmentOrders")]
	public class CreateFulfillmentOrderPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// CreateFulfillmentOrderRequest parameter
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public CreateFulfillmentOrderRequest Body { get; set; }
	}
}
