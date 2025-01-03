namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A decorator applied to a content string value in order to create rich text.
	/// </summary>
	public class Decorator : BaseClass
	{
		[JsonProperty("type")]
		public DecoratorType Type { get; set; }

		/// <summary>
		/// The starting character of this decorator within the content string. Use zero for the first character
		/// .
		/// </summary>
		[Minimum(0)]
		[Maximum(10000)]
		[JsonProperty("offset")]
		public int Offset { get; set; }

		/// <summary>
		/// The number of content characters to alter with this decorator. Decorators such as line breaks can have
		/// zero length and fit between characters.
		/// </summary>
		[Minimum(0)]
		[Maximum(10000)]
		[JsonProperty("length")]
		public int Length { get; set; }

		/// <summary>
		/// The relative intensity or variation of this decorator. Decorators such as bullet-points, for example,
		/// can have multiple indentation depths.
		/// </summary>
		[Minimum(0)]
		[Maximum(100)]
		[JsonProperty("depth")]
		public int Depth { get; set; }
	}
}
