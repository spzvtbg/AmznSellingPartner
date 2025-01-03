namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A standard background image with a floating text box.
	/// </summary>
	public class StandardImageTextOverlayModule : BaseClass
	{
		[IsRequired]
		[JsonProperty("overlayColorType")]
		public ColorType OverlayColorType { get; set; }

		[JsonProperty("block")]
		public StandardImageTextBlock Block { get; set; }
	}
}
