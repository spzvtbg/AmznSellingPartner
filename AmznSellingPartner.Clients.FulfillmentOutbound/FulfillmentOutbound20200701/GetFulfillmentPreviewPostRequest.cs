namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/fba/outbound/2020-07-01/fulfillmentOrders/preview")]
	public class GetFulfillmentPreviewPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// GetFulfillmentPreviewRequest parameter
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public GetFulfillmentPreviewRequest Body { get; set; }
	}
}
