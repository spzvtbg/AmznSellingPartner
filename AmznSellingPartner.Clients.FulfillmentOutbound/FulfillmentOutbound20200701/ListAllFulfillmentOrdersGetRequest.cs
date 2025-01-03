namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	[HttpGet("/fba/outbound/2020-07-01/fulfillmentOrders")]
	public class ListAllFulfillmentOrdersGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// A date used to select fulfillment orders that were last updated after (or at) a specified time. An update is d
		/// fined as any change in fulfillment order status, including the creation of a new fulfillment order.
		/// </summary>
		[InQuery("queryStartDate")]
		[JsonProperty("queryStartDate")]
		public DateTime QueryStartDate { get; set; }

		/// <summary>
		/// A string token returned in the response to your previous request.
		/// </summary>
		[InQuery("nextToken")]
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
