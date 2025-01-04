namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The weight of a package.
	/// </summary>
	public class Weight : BaseClass
	{
		[JsonProperty("unit")]
		[IsRequired]
		public UnitOfWeight Unit { get; set; } 

		/// <summary>
		/// Value of a weight.
		/// </summary>
		[JsonProperty("value")]
		[IsRequired]
		[Minimum(0)]
		[Maximum(100000)]
		public double Value { get; set; } 
	}
}
