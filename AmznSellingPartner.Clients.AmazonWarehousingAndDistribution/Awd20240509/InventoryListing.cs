namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// AWD inventory payload
	/// </summary>
	public class InventoryListing : BaseClass
	{
		/// <summary>
		/// List of inventory summaries
		/// </summary>
		[IsRequired]
		[JsonProperty("inventory")]
		public List<InventorySummary> Inventory { get; set; }

		/// <summary>
		/// A token that is used to retrieve the next page of results
		/// The response includes `nextToken` when the number of results exceeds the specified `maxResults` value
		/// To get the next page of results, call the operation with this token and include the same arguments as the cal
		/// that produced the token
		/// To get a complete list, call this operation until `nextToken` is null
		/// Note that this operation can return empty pages
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
