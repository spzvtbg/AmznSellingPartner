namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/vendor/directFulfillment/shipping/2021-12-28/shippingLabels/{purchaseOrderNumber}")]
	public class GetShippingLabelGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The purchase order number for which you want to return the shipping label
		/// It should be the same `purchaseOrderNumber` that you received in the order
		/// </summary>
		[InPath("purchaseOrderNumber")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }
	}
}
