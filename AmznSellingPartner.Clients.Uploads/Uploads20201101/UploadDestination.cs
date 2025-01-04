namespace AmznSellingPartner.Clients.Uploads.Uploads20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// Information about an upload destination.
	/// </summary>
	public class UploadDestination : BaseClass
	{
		/// <summary>
		/// The unique identifier for the upload destination.
		/// </summary>
		[JsonProperty("uploadDestinationId")]
		public string UploadDestinationId { get; set; } 

		/// <summary>
		/// The URL for the upload destination.
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; } 

		/// <summary>
		/// The headers to include in the upload request.
		/// </summary>
		[JsonProperty("headers")]
		public Headers Headers { get; set; } 
	}
}
