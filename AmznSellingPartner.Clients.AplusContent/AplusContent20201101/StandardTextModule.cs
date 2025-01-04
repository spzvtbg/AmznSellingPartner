namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A standard headline and body text.
	/// </summary>
	public class StandardTextModule : BaseClass
	{
		[JsonProperty("headline")]
		public TextComponent Headline { get; set; } 

		[JsonProperty("body")]
		[IsRequired]
		public ParagraphComponent Body { get; set; } 
	}
}
