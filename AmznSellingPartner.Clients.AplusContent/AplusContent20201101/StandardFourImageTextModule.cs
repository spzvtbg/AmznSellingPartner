namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// Four standard images with text, presented across a single row.
	/// </summary>
	public class StandardFourImageTextModule : BaseClass
	{
		[JsonProperty("headline")]
		public TextComponent Headline { get; set; }

		[JsonProperty("block1")]
		public StandardImageTextBlock Block1 { get; set; }

		[JsonProperty("block2")]
		public StandardImageTextBlock Block2 { get; set; }

		[JsonProperty("block3")]
		public StandardImageTextBlock Block3 { get; set; }

		[JsonProperty("block4")]
		public StandardImageTextBlock Block4 { get; set; }
	}
}
