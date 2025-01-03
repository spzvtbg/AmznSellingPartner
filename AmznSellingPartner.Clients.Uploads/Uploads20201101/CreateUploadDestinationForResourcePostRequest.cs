namespace AmznSellingPartner.Clients.Uploads.Uploads20201101
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpPost("/uploads/2020-11-01/uploadDestinations/{resource}")]
	public class CreateUploadDestinationForResourcePostRequest : BaseHttpRequest
	{
		/// <summary>
		/// A list of marketplace identifiers. This specifies the marketplaces where the upload will be available. Only on
		/// marketplace can be specified.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// An MD5 hash of the content to be submitted to the upload destination. This value is used to determine if the d
		/// ta has been corrupted or tampered with during transit.
		/// </summary>
		[InQuery("contentMD5")]
		[IsRequired]
		[JsonProperty("contentMD5")]
		public string ContentMD5 { get; set; }

		/// <summary>
		/// The resource for the upload destination that you are creating. For example, if you are creating an upload dest
		/// nation for the createLegalDisclosure operation of the Messaging API, the `{resource}` would be `/messaging/v1/
		/// rders/{amazonOrderId}/messages/legalDisclosure`, and the entire path would be `/uploads/2020-11-01/uploadDesti
		/// ations/messaging/v1/orders/{amazonOrderId}/messages/legalDisclosure`. If you are creating an upload destinatio
		/// for an Aplus content document, the `{resource}` would be `aplus/2020-11-01/contentDocuments` and the path wou
		/// d be `/uploads/v1/uploadDestinations/aplus/2020-11-01/contentDocuments`.
		/// </summary>
		[InPath("resource")]
		[IsRequired]
		[JsonProperty("resource")]
		public string Resource { get; set; }

		/// <summary>
		/// The content type of the file to be uploaded.
		/// </summary>
		[InQuery("contentType")]
		[JsonProperty("contentType")]
		public string ContentType { get; set; }
	}
}
