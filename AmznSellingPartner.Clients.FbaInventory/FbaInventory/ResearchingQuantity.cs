namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The number of misplaced or warehouse damaged units that are actively being confirmed at our fulfillment
	/// centers.
	/// </summary>
	public class ResearchingQuantity : BaseClass
	{
		/// <summary>
		/// The total number of units currently being researched in Amazon's fulfillment network.
		/// </summary>
		[JsonProperty("totalResearchingQuantity")]
		public int TotalResearchingQuantity { get; set; }

		/// <summary>
		/// A list of quantity details for items currently being researched.
		/// </summary>
		[JsonProperty("researchingQuantityBreakdown")]
		public List<ResearchingQuantityEntry> ResearchingQuantityBreakdown { get; set; }
	}
}
