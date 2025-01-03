namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The metadata for an A+ Content document, with additional information for content management
	/// </summary>
	public class ContentMetadataRecord : BaseClass
	{
		[IsRequired]
		[JsonProperty("contentReferenceKey")]
		public ContentReferenceKey ContentReferenceKey { get; set; }

		[IsRequired]
		[JsonProperty("contentMetadata")]
		public ContentMetadata ContentMetadata { get; set; }
	}
}
