namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An additional set of seller inputs required to purchase shipping.
	/// </summary>
	public class AdditionalSellerInputs : BaseClass
	{
		/// <summary>
		/// The name of the additional input field.
		/// </summary>
		[JsonProperty("AdditionalInputFieldName")]
		[IsRequired]
		public string AdditionalInputFieldName { get; set; } 

		[JsonProperty("AdditionalSellerInput")]
		[IsRequired]
		public AdditionalSellerInput AdditionalSellerInput { get; set; } 
	}
}
