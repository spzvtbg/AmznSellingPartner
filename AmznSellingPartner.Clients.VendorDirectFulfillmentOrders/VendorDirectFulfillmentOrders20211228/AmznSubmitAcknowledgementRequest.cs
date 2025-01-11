namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/vendor/directFulfillment/orders/2021-12-28/acknowledgements")]
	public class AmznSubmitAcknowledgementRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body containing the acknowledgement to an order
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public SubmitAcknowledgementRequest Body { get; set; } 
	}
}
