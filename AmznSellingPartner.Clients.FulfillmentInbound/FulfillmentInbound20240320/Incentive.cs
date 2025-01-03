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
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// Target of the incentive. Possible values: 'Placement Services', 'Fulfillment Fee Discount'.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("target")]
		public string Target { get; set; }

		/// <summary>
		/// Type of incentive. Possible values: `FEE`, `DISCOUNT`.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("type")]
		public string Type { get; set; }

		[IsRequired]
		[JsonProperty("value")]
		public Currency Value { get; set; }
	}
}
