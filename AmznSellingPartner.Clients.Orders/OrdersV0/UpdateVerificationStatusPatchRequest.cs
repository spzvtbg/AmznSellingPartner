namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPatch("/orders/v0/orders/{orderId}/regulatedInfo")]
	public class UpdateVerificationStatusPatchRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon-defined order identifier, in 3-7-7 format.
		/// </summary>
		[InPath("orderId")]
		[IsRequired]
		public string OrderId { get; set; } 

		/// <summary>
		/// The request body for the `updateVerificationStatus` operation.
		/// </summary>
		[InBody("payload")]
		[IsRequired]
		public UpdateVerificationStatusRequest Payload { get; set; } 
	}
}
