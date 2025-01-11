namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Representing the included/excluded benefits that we offer for each ShippingOffering/Rate. Benefits
	/// being services provided by Amazon when sellers purchase shipping through Amazon.
	/// </summary>
	public class Benefits : BaseClass
	{
		[JsonProperty("includedBenefits")]
		[IsRequired]
		public IncludedBenefits IncludedBenefits { get; set; } 

		[JsonProperty("excludedBenefits")]
		[IsRequired]
		public ExcludedBenefits ExcludedBenefits { get; set; } 
	}
}
