namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/vendor/orders/v1/acknowledgements")]
	public class SubmitAcknowledgementPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Submits acknowledgements for one or more purchase orders from a vendor.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public SubmitAcknowledgementRequest Body { get; set; }
	}
}
