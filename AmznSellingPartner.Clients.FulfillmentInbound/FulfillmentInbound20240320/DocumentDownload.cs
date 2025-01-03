namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Resource to download the requested document
	/// </summary>
	public class DocumentDownload : BaseClass
	{
		/// <summary>
		/// The type of download
		/// Possible values: `URL`
		/// </summary>
		[IsRequired]
		[JsonProperty("downloadType")]
		public string DownloadType { get; set; }

		/// <summary>
		/// The URI's expiration time
		/// In [ISO 8601](https://developer-docs
		/// amazon
		/// com/sp-api/docs/iso-8601) datetime format with pattern `yyyy-MM-ddTHH:mm:ss
		/// sssZ`
		/// </summary>
		[JsonProperty("expiration")]
		public DateTime Expiration { get; set; }

		/// <summary>
		/// Uniform resource identifier to identify where the document is located
		/// </summary>
		[IsRequired]
		[JsonProperty("uri")]
		public string Uri { get; set; }
	}
}
