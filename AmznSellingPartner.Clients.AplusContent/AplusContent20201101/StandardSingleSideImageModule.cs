namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A standard headline and body text with an image on the side
	/// </summary>
	public class StandardSingleSideImageModule : BaseClass
	{
		[IsRequired]
		[JsonProperty("imagePositionType")]
		public PositionType ImagePositionType { get; set; }

		[JsonProperty("block")]
		public StandardImageTextBlock Block { get; set; }
	}
}
