namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Four standard images with text, presented on a grid of four quadrants.
	/// </summary>
	public class StandardFourImageTextQuadrantModule : BaseClass
	{
		[JsonProperty("block1")]
		[IsRequired]
		public StandardImageTextBlock Block1 { get; set; }

		[JsonProperty("block2")]
		[IsRequired]
		public StandardImageTextBlock Block2 { get; set; }

		[JsonProperty("block3")]
		[IsRequired]
		public StandardImageTextBlock Block3 { get; set; }

		[JsonProperty("block4")]
		[IsRequired]
		public StandardImageTextBlock Block4 { get; set; }
	}
}
