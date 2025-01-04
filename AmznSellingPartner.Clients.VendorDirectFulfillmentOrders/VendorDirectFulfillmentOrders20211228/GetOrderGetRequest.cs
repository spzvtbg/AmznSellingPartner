namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/vendor/directFulfillment/orders/2021-12-28/purchaseOrders/{purchaseOrderNumber}")]
	public class GetOrderGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The order identifier for the purchase order that you want. Formatting Notes: alpha-numeric code.
		/// </summary>
		[InPath("purchaseOrderNumber")]
		[IsRequired]
		public string PurchaseOrderNumber { get; set; } 
	}
}
