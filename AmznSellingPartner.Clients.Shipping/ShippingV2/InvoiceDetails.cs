namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// The invoice details for charges associated with the goods in the package. Only applies to certain re
	/// gions.
	/// </summary>
	public class InvoiceDetails : BaseClass
	{
		/// <summary>
		/// The invoice number of the item.
		/// </summary>
		[JsonProperty("invoiceNumber")]
		public string InvoiceNumber { get; set; }

		/// <summary>
		/// The invoice date of the item in ISO 8061 format.
		/// </summary>
		[JsonProperty("invoiceDate")]
		public DateTime InvoiceDate { get; set; }
	}
}
