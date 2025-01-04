namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The image for the listings item.
	/// </summary>
	public class ItemImage : BaseClass
	{
		/// <summary>
		/// The link, or URL, to the image.
		/// </summary>
		[JsonProperty("link")]
		[IsRequired]
		public string Link { get; set; }

		/// <summary>
		/// The height of the image in pixels.
		/// </summary>
		[JsonProperty("height")]
		[IsRequired]
		public int Height { get; set; }

		/// <summary>
		/// The width of the image in pixels.
		/// </summary>
		[JsonProperty("width")]
		[IsRequired]
		public int Width { get; set; }
	}
}
