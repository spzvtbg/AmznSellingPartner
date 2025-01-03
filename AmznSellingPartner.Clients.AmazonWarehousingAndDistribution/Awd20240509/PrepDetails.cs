namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The preparation details for a product
	/// This contains the prep category, prep owner, and label owner
	/// Prep instructions are generated based on the specified category
	/// </summary>
	public class PrepDetails : BaseClass
	{
		[JsonProperty("labelOwner")]
		public LabelOwner LabelOwner { get; set; }

		/// <summary>
		/// The preparation category for shipping an item to Amazon's fulfillment network
		/// </summary>
		[JsonProperty("prepCategory")]
		public string PrepCategory { get; set; }

		/// <summary>
		/// Information that pertains to the preparation of inbound products
		/// This is generated based on the specified category
		/// </summary>
		[JsonProperty("prepInstructions")]
		public List<PrepInstruction> PrepInstructions { get; set; }

		[JsonProperty("prepOwner")]
		public PrepOwner PrepOwner { get; set; }
	}
}
