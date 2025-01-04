namespace AmznSellingPartner.Clients.ListingsRestrictions.ListingsRestrictions20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of restrictions for the specified Amazon catalog item.
	/// </summary>
	public class RestrictionList : BaseClass
	{
		[JsonProperty("restrictions")]
		[IsRequired]
		public List<Restriction> Restrictions { get; set; }
	}
}
