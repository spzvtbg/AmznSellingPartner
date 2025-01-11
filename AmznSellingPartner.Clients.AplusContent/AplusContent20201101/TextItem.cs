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
		/// The rank or index of this text item within the collection. Different items cannot occupy the
		/// same position within a single collection.
		/// </summary>
		[JsonProperty("position")]
		[IsRequired]
		[Minimum(1)]
		[Maximum(100)]
		public int Position { get; set; } 

		[JsonProperty("text")]
		[IsRequired]
		public TextComponent Text { get; set; } 
	}
}
