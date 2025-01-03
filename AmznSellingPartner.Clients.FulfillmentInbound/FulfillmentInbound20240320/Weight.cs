namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The weight of a package.
	/// </summary>
	public class Weight : BaseClass
	{
		[IsRequired]
		[JsonProperty("unit")]
		public UnitOfWeight Unit { get; set; }

		/// <summary>
		/// Value of a weight.
		/// </summary>
		[IsRequired]
		[Minimum(0)]
		[Maximum(100000)]
		[JsonProperty("value")]
		public double Value { get; set; }
	}
}
