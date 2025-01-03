namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// The A+ Content standard image and caption block.
	/// </summary>
	public class StandardImageCaptionBlock : BaseClass
	{
		[JsonProperty("image")]
		public ImageComponent Image { get; set; }

		[JsonProperty("caption")]
		public TextComponent Caption { get; set; }
	}
}
