namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The A+ Content standard comparison product block.
	/// </summary>
	public class StandardComparisonProductBlock : BaseClass
	{
		/// <summary>
		/// The rank or index of this comparison product block within the module. Different blocks cannot occupy
		/// the same position within a single module.
		/// </summary>
		[IsRequired]
		[Minimum(1)]
		[Maximum(6)]
		[JsonProperty("position")]
		public int Position { get; set; }

		[JsonProperty("image")]
		public ImageComponent Image { get; set; }

		/// <summary>
		/// The comparison product title.
		/// </summary>
		[MinLength(1)]
		[MaxLength(80)]
		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("asin")]
		public Asin Asin { get; set; }

		/// <summary>
		/// Determines whether this block of content is visually highlighted.
		/// </summary>
		[JsonProperty("highlight")]
		public bool Highlight { get; set; }

		/// <summary>
		/// Comparison metrics for the product.
		/// </summary>
		[MinItems(0)]
		[MaxItems(10)]
		[JsonProperty("metrics")]
		public List<PlainTextItem> Metrics { get; set; }
	}
}
