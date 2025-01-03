namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Packing slip information
	/// </summary>
	public class PackingSlip : BaseClass
	{
		/// <summary>
		/// Purchase order number of the shipment that the packing slip is for
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9]+")]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// A Base64encoded string of the packing slip PDF
		/// </summary>
		[IsRequired]
		[JsonProperty("content")]
		public string Content { get; set; }

		/// <summary>
		/// The format of the file such as PDF, JPEG etc
		/// </summary>
		[JsonProperty("contentType")]
		public ContentType ContentType { get; set; }
	}
}
