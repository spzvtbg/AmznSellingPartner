namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Provides detailed information about an invoice.
	/// </summary>
	public class Invoice : BaseClass
	{
		/// <summary>
		/// The date and time the invoice is issued. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/doc
		/// /iso-8601) date-time format.
		/// </summary>
		[JsonProperty("date")]
		public DateTime Date { get; set; }

		/// <summary>
		/// If the invoice is in an error state, this attribute displays the error code.
		/// </summary>
		[JsonProperty("errorCode")]
		public string ErrorCode { get; set; }

		/// <summary>
		/// The invoice identifier that is used by an external party. This is typically the government agency that authori
		/// ed the invoice.
		/// </summary>
		[JsonProperty("externalInvoiceId")]
		public string ExternalInvoiceId { get; set; }

		/// <summary>
		/// The response message from the government authority when there is an error during invoice issuance.
		/// </summary>
		[JsonProperty("govResponse")]
		public string GovResponse { get; set; }

		/// <summary>
		/// The invoice identifier.
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// The classification of the invoice type. This varies across marketplaces. Use the `getInvoicesAttributes` opera
		/// ion to check `invoiceType` options.
		/// </summary>
		[JsonProperty("invoiceType")]
		public string InvoiceType { get; set; }

		/// <summary>
		/// Use this identifier in conjunction with `externalInvoiceId` to identify invoices from the same seller.
		/// </summary>
		[JsonProperty("series")]
		public string Series { get; set; }

		/// <summary>
		/// The invoice status classification. Use the `getInvoicesAttributes` operation to check invoice status options.
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }

		/// <summary>
		/// List with identifiers for the transactions associated to the invoice.
		/// </summary>
		[JsonProperty("transactionIds")]
		public List<TransactionIdentifier> TransactionIds { get; set; }

		/// <summary>
		/// Classification of the transaction that originated this invoice. Use the `getInvoicesAttributes` operation to c
		/// eck `transactionType` options.
		/// </summary>
		[JsonProperty("transactionType")]
		public string TransactionType { get; set; }
	}
}
