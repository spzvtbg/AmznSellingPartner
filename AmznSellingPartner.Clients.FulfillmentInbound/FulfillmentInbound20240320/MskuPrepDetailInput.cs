namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// An MSKU and its related prep details
	/// </summary>
	public class MskuPrepDetailInput : BaseClass
	{
		/// <summary>
		/// The merchant SKU, a merchant-supplied identifier for a specific SKU
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(40)]
		[JsonProperty("msku")]
		public string Msku { get; set; }

		[IsRequired]
		[JsonProperty("prepCategory")]
		public PrepCategory PrepCategory { get; set; }

		/// <summary>
		/// A list of preparation types associated with a preparation category
		/// </summary>
		[IsRequired]
		[JsonProperty("prepTypes")]
		public List<PrepType> PrepTypes { get; set; }
	}
}
