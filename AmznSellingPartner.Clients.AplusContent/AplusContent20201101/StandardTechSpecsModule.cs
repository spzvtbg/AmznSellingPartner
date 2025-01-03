namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The standard table of technical feature names and definitions.
	/// </summary>
	public class StandardTechSpecsModule : BaseClass
	{
		[JsonProperty("headline")]
		public TextComponent Headline { get; set; }

		/// <summary>
		/// The specification list.
		/// </summary>
		[IsRequired]
		[MinItems(4)]
		[MaxItems(16)]
		[JsonProperty("specificationList")]
		public List<StandardTextPairBlock> SpecificationList { get; set; }

		/// <summary>
		/// The number of tables to present. Features are evenly divided between the tables.
		/// </summary>
		[Minimum(1)]
		[Maximum(2)]
		[JsonProperty("tableCount")]
		public int TableCount { get; set; }
	}
}
