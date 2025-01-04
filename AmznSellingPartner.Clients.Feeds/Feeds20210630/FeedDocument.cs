namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information required for the feed document.
	/// </summary>
	public class FeedDocument : BaseClass
	{
		/// <summary>
		/// The identifier for the feed document. This identifier is unique only in combination with a seller ID
		/// .
		/// </summary>
		[JsonProperty("feedDocumentId")]
		[IsRequired]
		public string FeedDocumentId { get; set; } 

		/// <summary>
		/// A presigned URL for the feed document. If `compressionAlgorithm` is not returned, you can download the
		/// feed directly from this URL. This URL expires after 5 minutes.
		/// </summary>
		[JsonProperty("url")]
		[IsRequired]
		public string Url { get; set; } 

		/// <summary>
		/// If the feed document contents have been compressed, the compression algorithm used is returned in this
		/// property and you must decompress the feed when you download. Otherwise, you can download the feed directly.
		/// Refer to [Step 7. Download the feed processing report](doc:feeds-api-v2021-06-30-use-case-guide#step-7-download-the-feed-processing-report)
		/// in the use case guide, where sample code is provided.
		/// </summary>
		[JsonProperty("compressionAlgorithm")]
		public CompressionAlgorithm CompressionAlgorithm { get; set; } 
	}
}
