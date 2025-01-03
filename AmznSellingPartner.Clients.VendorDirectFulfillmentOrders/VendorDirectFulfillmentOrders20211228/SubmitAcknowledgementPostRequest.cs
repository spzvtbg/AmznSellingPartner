namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/vendor/directFulfillment/orders/2021-12-28/acknowledgements")]
	public class SubmitAcknowledgementPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body containing the acknowledgement to an order
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public SubmitAcknowledgementRequest Body { get; set; }
	}
}
