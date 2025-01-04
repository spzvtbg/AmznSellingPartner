namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The response for the `getDocument` operation.
	/// </summary>
	public class GetDocumentResponse : BaseClass
	{
		/// <summary>
		/// The identifier for the Data Kiosk document. This identifier is unique only in combination with a selling
		/// partner account ID.
		/// </summary>
		[JsonProperty("documentId")]
		[IsRequired]
		public string DocumentId { get; set; }

		/// <summary>
		/// A presigned URL that can be used to retrieve the Data Kiosk document. This URL expires after 5 minutes.
		/// If the Data Kiosk document is compressed, the `Content-Encoding` header will indicate the compression
		/// algorithm.  **Note:** Most HTTP clients are capable of automatically decompressing downloaded files based
		/// on the `Content-Encoding` header.
		/// </summary>
		[JsonProperty("documentUrl")]
		[IsRequired]
		public string DocumentUrl { get; set; }
	}
}
