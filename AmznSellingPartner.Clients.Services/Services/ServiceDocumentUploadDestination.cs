namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about an upload destination
	/// </summary>
	public class ServiceDocumentUploadDestination : BaseClass
	{
		/// <summary>
		/// The unique identifier to be used by APIs that reference the upload destination
		/// </summary>
		[IsRequired]
		[JsonProperty("uploadDestinationId")]
		public string UploadDestinationId { get; set; }

		/// <summary>
		/// The URL to which to upload the file
		/// </summary>
		[IsRequired]
		[JsonProperty("url")]
		public string Url { get; set; }

		[IsRequired]
		[JsonProperty("encryptionDetails")]
		public EncryptionDetails EncryptionDetails { get; set; }

		/// <summary>
		/// The headers to include in the upload request
		/// </summary>
		[JsonProperty("headers")]
		public Headers Headers { get; set; }
	}
}
