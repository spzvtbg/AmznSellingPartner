namespace AmznSellingPartner.Clients.ListingsRestrictions.ListingsRestrictions20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A reason for the restriction, including path forward links that may allow Selling Partners to remove
	/// the restriction, if available.
	/// </summary>
	public class Reason : BaseClass
	{
		/// <summary>
		/// A message describing the reason for the restriction.
		/// </summary>
		[JsonProperty("message")]
		[IsRequired]
		public string Message { get; set; }

		/// <summary>
		/// A code indicating why the listing is restricted.
		/// </summary>
		[JsonProperty("reasonCode")]
		public ReasonCode ReasonCode { get; set; }

		/// <summary>
		/// A list of path forward links that may allow Selling Partners to remove the restriction.
		/// </summary>
		[JsonProperty("links")]
		public List<Link> Links { get; set; }
	}
}
