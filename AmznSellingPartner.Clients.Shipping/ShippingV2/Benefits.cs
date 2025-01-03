namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Representing the included/excluded benefits that we offer for each ShippingOffering/Rate. Benefits being
	/// services provided by Amazon when sellers purchase shipping through Amazon.
	/// </summary>
	public class Benefits : BaseClass
	{
		[IsRequired]
		[JsonProperty("includedBenefits")]
		public IncludedBenefits IncludedBenefits { get; set; }

		[IsRequired]
		[JsonProperty("excludedBenefits")]
		public ExcludedBenefits ExcludedBenefits { get; set; }
	}
}
