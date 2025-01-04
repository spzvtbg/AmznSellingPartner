namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Represents a list of customer invoices, potentially paginated.
	/// </summary>
	public class CustomerInvoiceList : BaseClass
	{
		/// <summary>
		/// The pagination elements required to retrieve the remaining data.
		/// </summary>
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; } 

		/// <summary>
		/// Represents a customer invoice within the `CustomerInvoiceList`.
		/// </summary>
		[JsonProperty("customerInvoices")]
		public List<CustomerInvoice> CustomerInvoices { get; set; } 
	}
}
