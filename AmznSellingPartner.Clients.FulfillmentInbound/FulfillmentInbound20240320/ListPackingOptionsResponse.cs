namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `listPlacementOptions` response.
	/// </summary>
	public class ListPackingOptionsResponse : BaseClass
	{
		/// <summary>
		/// List of packing options.
		/// </summary>
		[JsonProperty("packingOptions")]
		[IsRequired]
		public List<PackingOption> PackingOptions { get; set; } 

		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; } 
	}
}
