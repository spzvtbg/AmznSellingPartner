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
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// The Base64encoded customer invoice.
		/// </summary>
		[IsRequired]
		[JsonProperty("content")]
		public string Content { get; set; }
	}
}
