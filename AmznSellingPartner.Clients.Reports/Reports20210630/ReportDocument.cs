namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information required for the report document.
	/// </summary>
	public class ReportDocument : BaseClass
	{
		/// <summary>
		/// The identifier for the report document. This identifier is unique only in combination with a seller
		/// ID.
		/// </summary>
		[JsonProperty("reportDocumentId")]
		[IsRequired]
		public string ReportDocumentId { get; set; } 

		/// <summary>
		/// A presigned URL for the report document. If `compressionAlgorithm` is not returned, you can download
		/// the report directly from this URL. This URL expires after 5 minutes.
		/// </summary>
		[JsonProperty("url")]
		[IsRequired]
		public string Url { get; set; } 

		/// <summary>
		/// If the report document contents have been compressed, the compression algorithm used is returned in this
		/// property and you must decompress the report when you download. Otherwise, you can download the report
		/// directly. Refer to [Step 2. Download the report](https://developer-docs.amazon.com/sp-api/docs/reports-api-v2021-06-30-retrieve-a-report#step-2-download-the-report)
		/// in the use case guide, where sample code is provided.
		/// </summary>
		[JsonProperty("compressionAlgorithm")]
		public CompressionAlgorithm CompressionAlgorithm { get; set; } 
	}
}
