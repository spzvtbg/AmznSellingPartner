namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents a customer invoice associated with a purchase order.
	/// </summary>
	public class CustomerInvoice : BaseClass
	{
		/// <summary>
		/// The purchase order number for this order.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// The Base64encoded customer invoice.
		/// </summary>
		[JsonProperty("content")]
		[IsRequired]
		public string Content { get; set; }
	}
}
