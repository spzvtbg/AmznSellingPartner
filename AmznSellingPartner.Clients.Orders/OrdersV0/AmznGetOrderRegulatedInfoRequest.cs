namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/orders/v0/orders/{orderId}/regulatedInfo")]
	public class AmznGetOrderRegulatedInfoRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon-defined order identifier, in 3-7-7 format.
		/// </summary>
		[InPath("orderId")]
		[IsRequired]
		public string OrderId { get; set; } 
	}
}
