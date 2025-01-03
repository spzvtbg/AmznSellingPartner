namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// The A+ Content standard label and description block, comprised of a pair of text components.
	/// </summary>
	public class StandardTextPairBlock : BaseClass
	{
		[JsonProperty("label")]
		public TextComponent Label { get; set; }

		[JsonProperty("description")]
		public TextComponent Description { get; set; }
	}
}
