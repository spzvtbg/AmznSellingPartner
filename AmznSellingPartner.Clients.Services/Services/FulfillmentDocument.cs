namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// Document that captured during service appointment fulfillment that portrays proof of completion
	/// </summary>
	public class FulfillmentDocument : BaseClass
	{
		/// <summary>
		/// The identifier of the upload destination. Get this value by calling the `createServiceDocumentUploadDestinatio
		/// ` operation of the Services API.
		/// </summary>
		[JsonProperty("uploadDestinationId")]
		public string UploadDestinationId { get; set; }

		/// <summary>
		/// Sha256 hash of the file content. This value is used to determine if the file has been corrupted or tampered wi
		/// h during transit.
		/// </summary>
		[JsonProperty("contentSha256")]
		public string ContentSha256 { get; set; }
	}
}
