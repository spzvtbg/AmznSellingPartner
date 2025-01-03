namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// The A+ Content standard image and text box block
	/// </summary>
	public class StandardImageTextBlock : BaseClass
	{
		[JsonProperty("image")]
		public ImageComponent Image { get; set; }

		[JsonProperty("headline")]
		public TextComponent Headline { get; set; }

		[JsonProperty("body")]
		public ParagraphComponent Body { get; set; }
	}
}
