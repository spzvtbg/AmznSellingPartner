namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/orders/v0/orders/{orderId}/shipmentConfirmation")]
	public class ConfirmShipmentPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon-defined order identifier, in 3-7-7 format
		/// </summary>
		[InPath("orderId")]
		[IsRequired]
		[JsonProperty("orderId")]
		public string OrderId { get; set; }

		/// <summary>
		/// Request body of `confirmShipment`
		/// </summary>
		[InBody("payload")]
		[IsRequired]
		[JsonProperty("payload")]
		public ConfirmShipmentRequest Payload { get; set; }
	}
}
