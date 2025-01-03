namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The image for the listings item
	/// </summary>
	public class ItemImage : BaseClass
	{
		/// <summary>
		/// The link, or URL, to the image
		/// </summary>
		[IsRequired]
		[JsonProperty("link")]
		public string Link { get; set; }

		/// <summary>
		/// The height of the image in pixels
		/// </summary>
		[IsRequired]
		[JsonProperty("height")]
		public int Height { get; set; }

		/// <summary>
		/// The width of the image in pixels
		/// </summary>
		[IsRequired]
		[JsonProperty("width")]
		public int Width { get; set; }
	}
}
