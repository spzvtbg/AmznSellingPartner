namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/orders/v0/orders/{orderId}/shipment")]
	public class UpdateShipmentStatusPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon-defined order identifier, in 3-7-7 format.
		/// </summary>
		[InPath("orderId")]
		[IsRequired]
		public string OrderId { get; set; } 

		/// <summary>
		/// The request body for the `updateShipmentStatus` operation.
		/// </summary>
		[InBody("payload")]
		[IsRequired]
		public UpdateShipmentStatusRequest Payload { get; set; } 
	}
}
