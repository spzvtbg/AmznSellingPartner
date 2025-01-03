namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Rich positional text, usually presented as a collection of bullet points.
	/// </summary>
	public class TextItem : BaseClass
	{
		/// <summary>
		/// The rank or index of this text item within the collection. Different items cannot occupy the same position wit
		/// in a single collection.
		/// </summary>
		[IsRequired]
		[Minimum(1)]
		[Maximum(100)]
		[JsonProperty("position")]
		public int Position { get; set; }

		[IsRequired]
		[JsonProperty("text")]
		public TextComponent Text { get; set; }
	}
}
