namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Plain positional text, used in collections of brief labels and descriptors.
	/// </summary>
	public class PlainTextItem : BaseClass
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

		/// <summary>
		/// The actual plain text.
		/// </summary>
		[JsonProperty("value")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(250)]
		public string Value { get; set; } 
	}
}
