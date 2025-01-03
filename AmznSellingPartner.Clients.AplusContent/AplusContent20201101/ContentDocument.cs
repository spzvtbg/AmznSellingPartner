namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The A+ Content document
	/// This is the enhanced content that is published to product detail pages
	/// </summary>
	public class ContentDocument : BaseClass
	{
		/// <summary>
		/// The A+ Content document name
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		[JsonProperty("name")]
		public string Name { get; set; }

		[IsRequired]
		[JsonProperty("contentType")]
		public ContentType ContentType { get; set; }

		[JsonProperty("contentSubType")]
		public ContentSubType ContentSubType { get; set; }

		[IsRequired]
		[JsonProperty("locale")]
		public LanguageTag Locale { get; set; }

		[IsRequired]
		[JsonProperty("contentModuleList")]
		public ContentModuleList ContentModuleList { get; set; }
	}
}
