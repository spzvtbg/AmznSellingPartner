namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A list of item level fields.
	/// </summary>
	public class ItemLevelFields : BaseClass
	{
		/// <summary>
		/// The Amazon Standard Identification Number (ASIN) of the item.
		/// </summary>
		[IsRequired]
		[JsonProperty("Asin")]
		public string Asin { get; set; }

		[IsRequired]
		[JsonProperty("AdditionalInputs")]
		public AdditionalInputsList AdditionalInputs { get; set; }
	}
}
