namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The full context for an A+ Content publishing event.
	/// </summary>
	public class PublishRecord : BaseClass
	{
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public MarketplaceId MarketplaceId { get; set; }

		[JsonProperty("locale")]
		[IsRequired]
		public LanguageTag Locale { get; set; }

		[JsonProperty("asin")]
		[IsRequired]
		public Asin Asin { get; set; }

		[JsonProperty("contentType")]
		[IsRequired]
		public ContentType ContentType { get; set; }

		[JsonProperty("contentSubType")]
		public ContentSubType ContentSubType { get; set; }

		[JsonProperty("contentReferenceKey")]
		[IsRequired]
		public ContentReferenceKey ContentReferenceKey { get; set; }
	}
}
