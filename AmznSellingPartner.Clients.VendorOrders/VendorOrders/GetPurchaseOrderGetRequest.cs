namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/vendor/orders/v1/purchaseOrders/{purchaseOrderNumber}")]
	public class GetPurchaseOrderGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The purchase order identifier for the order that you want. Formatting Notes: 8-character alpha-numeric
		/// code.
		/// </summary>
		[InPath("purchaseOrderNumber")]
		[IsRequired]
		public string PurchaseOrderNumber { get; set; }
	}
}
