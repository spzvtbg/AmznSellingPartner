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
		[IsRequired]
		[JsonProperty("AdditionalInputFieldName")]
		public string AdditionalInputFieldName { get; set; }

		[IsRequired]
		[JsonProperty("AdditionalSellerInput")]
		public AdditionalSellerInput AdditionalSellerInput { get; set; }
	}
}
