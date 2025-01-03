namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/vendor/directFulfillment/shipping/2021-12-28/customerInvoices/{purchaseOrderNumber}")]
	public class GetCustomerInvoiceGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// Purchase order number of the shipment for which to return the invoice.
		/// </summary>
		[InPath("purchaseOrderNumber")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }
	}
}
