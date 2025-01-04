namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Contains details about cost related modifications to the placement cost.
	/// </summary>
	public class Incentive : BaseClass
	{
		/// <summary>
		/// Description of the incentive.
		/// </summary>
		[JsonProperty("description")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		public string Description { get; set; }

		/// <summary>
		/// Target of the incentive. Possible values: 'Placement Services', 'Fulfillment Fee Discount'.
		/// </summary>
		[JsonProperty("target")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		public string Target { get; set; }

		/// <summary>
		/// Type of incentive. Possible values: `FEE`, `DISCOUNT`.
		/// </summary>
		[JsonProperty("type")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		public string Type { get; set; }

		[JsonProperty("value")]
		[IsRequired]
		public Currency Value { get; set; }
	}
}
