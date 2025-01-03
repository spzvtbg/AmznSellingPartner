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
		/// The rank or index of this text item within the collection. Different items cannot occupy the same position wit
		/// in a single collection.
		/// </summary>
		[IsRequired]
		[Minimum(1)]
		[Maximum(100)]
		[JsonProperty("position")]
		public int Position { get; set; }

		/// <summary>
		/// The actual plain text.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(250)]
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
