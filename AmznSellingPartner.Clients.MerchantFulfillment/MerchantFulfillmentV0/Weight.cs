namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The weight.
	/// </summary>
	public class Weight : BaseClass
	{
		[IsRequired]
		[JsonProperty("Value")]
		public WeightValue Value { get; set; }

		[IsRequired]
		[JsonProperty("Unit")]
		public UnitOfWeight Unit { get; set; }
	}
}
