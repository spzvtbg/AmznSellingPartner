namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The A+ Content ASIN with additional metadata for content management
	/// If you don't include the `includedDataSet` parameter in a call to the listContentDocumentAsinRelations operat
	/// on, the related ASINs are returned without metadata
	/// </summary>
	public class AsinMetadata : BaseClass
	{
		[IsRequired]
		[JsonProperty("asin")]
		public Asin Asin { get; set; }

		[JsonProperty("badgeSet")]
		public AsinBadgeSet BadgeSet { get; set; }

		[JsonProperty("parent")]
		public Asin Parent { get; set; }

		/// <summary>
		/// The title for the ASIN in the Amazon catalog
		/// </summary>
		[MinLength(1)]
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// The default image for the ASIN in the Amazon catalog
		/// </summary>
		[MinLength(1)]
		[JsonProperty("imageUrl")]
		public string ImageUrl { get; set; }

		[JsonProperty("contentReferenceKeySet")]
		public ContentReferenceKeySet ContentReferenceKeySet { get; set; }
	}
}
