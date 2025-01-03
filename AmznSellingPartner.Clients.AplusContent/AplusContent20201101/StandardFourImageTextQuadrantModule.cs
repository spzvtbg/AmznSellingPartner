namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Four standard images with text, presented on a grid of four quadrants.
	/// </summary>
	public class StandardFourImageTextQuadrantModule : BaseClass
	{
		[IsRequired]
		[JsonProperty("block1")]
		public StandardImageTextBlock Block1 { get; set; }

		[IsRequired]
		[JsonProperty("block2")]
		public StandardImageTextBlock Block2 { get; set; }

		[IsRequired]
		[JsonProperty("block3")]
		public StandardImageTextBlock Block3 { get; set; }

		[IsRequired]
		[JsonProperty("block4")]
		public StandardImageTextBlock Block4 { get; set; }
	}
}
