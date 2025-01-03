namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Image for an item in the Amazon catalog.
	/// </summary>
	public class ItemImage : BaseClass
	{
		/// <summary>
		/// Variant of the image, such as `MAIN` or `PT01`.
		/// </summary>
		[IsRequired]
		[JsonProperty("variant")]
		public Variant Variant { get; set; }

		/// <summary>
		/// Link, or URL, for the image.
		/// </summary>
		[IsRequired]
		[JsonProperty("link")]
		public string Link { get; set; }

		/// <summary>
		/// Height of the image in pixels.
		/// </summary>
		[IsRequired]
		[JsonProperty("height")]
		public int Height { get; set; }

		/// <summary>
		/// Width of the image in pixels.
		/// </summary>
		[IsRequired]
		[JsonProperty("width")]
		public int Width { get; set; }
	}
}
