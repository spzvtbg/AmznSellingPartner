namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/vendor/directFulfillment/shipping/2021-12-28/shippingLabels/{purchaseOrderNumber}")]
	public class AmznCreateShippingLabelsRequest : BaseHttpRequest
	{
		/// <summary>
		/// The purchase order number for which you want to return the shipping labels. It should be the
		/// same number as the `purchaseOrderNumber` in the order.
		/// </summary>
		[InPath("purchaseOrderNumber")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		public string PurchaseOrderNumber { get; set; } 

		/// <summary>
		/// The request payload that contains the parameters for creating shipping labels.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public CreateShippingLabelsRequest Body { get; set; } 
	}
}
