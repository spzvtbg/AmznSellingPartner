namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The full context for an A+ Content publishing event.
	/// </summary>
	public class PublishRecord : BaseClass
	{
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public MarketplaceId MarketplaceId { get; set; }

		[IsRequired]
		[JsonProperty("locale")]
		public LanguageTag Locale { get; set; }

		[IsRequired]
		[JsonProperty("asin")]
		public Asin Asin { get; set; }

		[IsRequired]
		[JsonProperty("contentType")]
		public ContentType ContentType { get; set; }

		[JsonProperty("contentSubType")]
		public ContentSubType ContentSubType { get; set; }

		[IsRequired]
		[JsonProperty("contentReferenceKey")]
		public ContentReferenceKey ContentReferenceKey { get; set; }
	}
}
