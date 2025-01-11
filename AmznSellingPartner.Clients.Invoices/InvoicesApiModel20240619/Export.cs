namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Detailed information about the export.
	/// </summary>
	public class Export : BaseClass
	{
		/// <summary>
		/// When the export generation fails, this attribute contains a description of the error.
		/// </summary>
		[JsonProperty("errorMessage")]
		public string ErrorMessage { get; set; } 

		/// <summary>
		/// The export identifier.
		/// </summary>
		[JsonProperty("exportId")]
		public string ExportId { get; set; } 

		/// <summary>
		/// The date and time when the export generation finished. Vales are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date-time format.
		/// </summary>
		[JsonProperty("generateExportFinishedAt")]
		public DateTimeValue GenerateExportFinishedAt { get; set; } 

		/// <summary>
		/// The date and time when the export generation started. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date-time format.
		/// </summary>
		[JsonProperty("generateExportStartedAt")]
		public DateTimeValue GenerateExportStartedAt { get; set; } 

		/// <summary>
		/// The identifier for the export documents. To get the information required to retrieve the export
		/// document's contents, pass each ID in the `getInvoicesDocument` operation.  This list is empty
		/// until the status is `DONE`.
		/// </summary>
		[JsonProperty("invoicesDocumentIds")]
		public List<string> InvoicesDocumentIds { get; set; } 

		[JsonProperty("status")]
		public ExportStatus Status { get; set; } 
	}
}
