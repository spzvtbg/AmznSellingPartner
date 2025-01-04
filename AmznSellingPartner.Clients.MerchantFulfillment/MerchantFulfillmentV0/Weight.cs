namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The weight.
	/// </summary>
	public class Weight : BaseClass
	{
		[JsonProperty("Value")]
		[IsRequired]
		public WeightValue Value { get; set; } 

		[JsonProperty("Unit")]
		[IsRequired]
		public UnitOfWeight Unit { get; set; } 
	}
}
