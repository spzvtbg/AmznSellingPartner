namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/orders/v0/orders/{orderId}/buyerInfo")]
	public class GetOrderBuyerInfoGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// An `orderId` is an Amazon-defined order identifier, in 3-7-7 format
		/// </summary>
		[InPath("orderId")]
		[IsRequired]
		[JsonProperty("orderId")]
		public string OrderId { get; set; }
	}
}
