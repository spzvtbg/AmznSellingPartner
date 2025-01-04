namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// The information required to create the export request.
	/// </summary>
	public class ExportInvoicesRequest : BaseClass
	{
		/// <summary>
		/// The latest invoice creation date for invoices that you want to include in the response. Dates are in
		/// [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. The default is the
		/// time of the request.
		/// </summary>
		[JsonProperty("dateEnd")]
		public DateTime DateEnd { get; set; } 

		/// <summary>
		/// The earliest invoice creation date for invoices that you want to include in the response. Dates are in
		/// [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format. The default is 24
		/// hours prior to the time of the request.
		/// </summary>
		[JsonProperty("dateStart")]
		public DateTime DateStart { get; set; } 

		/// <summary>
		/// The external ID of the invoices you want included in the response.
		/// </summary>
		[JsonProperty("externalInvoiceId")]
		public string ExternalInvoiceId { get; set; } 

		[JsonProperty("fileFormat")]
		public FileFormat FileFormat { get; set; } 

		/// <summary>
		/// The marketplace-specific classification of the invoice type. Use the `getInvoicesAttributes` operation
		/// to check `invoiceType` options.
		/// </summary>
		[JsonProperty("invoiceType")]
		public string InvoiceType { get; set; } 

		/// <summary>
		/// The ID of the marketplace from which you want the invoices.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// The series number of the invoices you want included in the response.
		/// </summary>
		[JsonProperty("series")]
		public string Series { get; set; } 

		/// <summary>
		/// A list of statuses that you can use to filter invoices. Use the `getInvoicesAttributes` operation to
		/// check invoice status options.  Min count: 1
		/// </summary>
		[JsonProperty("statuses")]
		[MinItems(1)]
		public List<string> Statuses { get; set; } 

		[JsonProperty("transactionIdentifier")]
		public TransactionIdentifier TransactionIdentifier { get; set; } 

		/// <summary>
		/// The marketplace-specific classification of the transaction type for which the invoice was created. Use
		/// the `getInvoicesAttributes` operation to check `transactionType` options
		/// </summary>
		[JsonProperty("transactionType")]
		public string TransactionType { get; set; } 
	}
}
