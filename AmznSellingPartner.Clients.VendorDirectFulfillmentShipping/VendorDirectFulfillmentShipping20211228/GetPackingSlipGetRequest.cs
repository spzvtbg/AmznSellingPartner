namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/vendor/directFulfillment/shipping/2021-12-28/packingSlips/{purchaseOrderNumber}")]
	public class GetPackingSlipGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The `purchaseOrderNumber` for the packing slip that you want.
		/// </summary>
		[InPath("purchaseOrderNumber")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }
	}
}
