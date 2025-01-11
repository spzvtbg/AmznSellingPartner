namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using Newtonsoft.Json;

	/// <summary>
	/// An object that contains the `documentId` and an S3 pre-signed URL that you can use to download
	/// the specified file.
	/// </summary>
	public class InvoicesDocument : BaseClass
	{
		/// <summary>
		/// The identifier of the export document.
		/// </summary>
		[JsonProperty("invoicesDocumentId")]
		public string InvoicesDocumentId { get; set; } 

		/// <summary>
		/// A pre-signed URL that you can use to download the invoices document in zip format. This URL
		/// expires after 30 seconds.
		/// </summary>
		[JsonProperty("invoicesDocumentUrl")]
		public string InvoicesDocumentUrl { get; set; } 
	}
}
