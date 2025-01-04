namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Specifies characteristics that apply to a seller input.
	/// </summary>
	public class SellerInputDefinition : BaseClass
	{
		/// <summary>
		/// When true, the additional input field is required.
		/// </summary>
		[JsonProperty("IsRequired")]
		[IsRequired]
		public bool IsRequired { get; set; } 

		/// <summary>
		/// The data type of the additional input field.
		/// </summary>
		[JsonProperty("DataType")]
		[IsRequired]
		public string DataType { get; set; } 

		[JsonProperty("Constraints")]
		[IsRequired]
		public Constraints Constraints { get; set; } 

		/// <summary>
		/// The display text for the additional input field.
		/// </summary>
		[JsonProperty("InputDisplayText")]
		[IsRequired]
		public string InputDisplayText { get; set; } 

		/// <summary>
		/// Whether the seller input applies to the item or the shipment.
		/// </summary>
		[JsonProperty("InputTarget")]
		public InputTargetType InputTarget { get; set; } 

		[JsonProperty("StoredValue")]
		[IsRequired]
		public AdditionalSellerInput StoredValue { get; set; } 

		[JsonProperty("RestrictedSetValues")]
		public RestrictedSetValues RestrictedSetValues { get; set; } 
	}
}
