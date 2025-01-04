namespace AmznSellingPartner.Clients.ListingsRestrictions.ListingsRestrictions20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A listing restriction, optionally qualified by a condition, with a list of reasons for the restricti
	/// on.
	/// </summary>
	public class Restriction : BaseClass
	{
		/// <summary>
		/// A marketplace identifier. Identifies the Amazon marketplace where the restriction is enforced.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The condition that applies to the restriction.
		/// </summary>
		[JsonProperty("conditionType")]
		public ConditionType ConditionType { get; set; }

		/// <summary>
		/// A list of reasons for the restriction.
		/// </summary>
		[JsonProperty("reasons")]
		public List<Reason> Reasons { get; set; }
	}
}
