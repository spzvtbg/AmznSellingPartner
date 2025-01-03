namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// The A+ Content standard image and text block, with a related caption
	/// The caption may not display on all devices
	/// </summary>
	public class StandardImageTextCaptionBlock : BaseClass
	{
		[JsonProperty("block")]
		public StandardImageTextBlock Block { get; set; }

		[JsonProperty("caption")]
		public TextComponent Caption { get; set; }
	}
}
