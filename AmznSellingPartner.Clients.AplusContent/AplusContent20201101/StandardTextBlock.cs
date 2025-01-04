namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// The A+ Content standard text box block, comprised of a paragraph with a headline.
	/// </summary>
	public class StandardTextBlock : BaseClass
	{
		[JsonProperty("headline")]
		public TextComponent Headline { get; set; } 

		[JsonProperty("body")]
		public ParagraphComponent Body { get; set; } 
	}
}
