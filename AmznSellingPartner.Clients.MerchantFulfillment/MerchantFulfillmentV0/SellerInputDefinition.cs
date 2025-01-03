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
		[IsRequired]
		[JsonProperty("IsRequired")]
		public bool IsRequired { get; set; }

		/// <summary>
		/// The data type of the additional input field.
		/// </summary>
		[IsRequired]
		[JsonProperty("DataType")]
		public string DataType { get; set; }

		[IsRequired]
		[JsonProperty("Constraints")]
		public Constraints Constraints { get; set; }

		/// <summary>
		/// The display text for the additional input field.
		/// </summary>
		[IsRequired]
		[JsonProperty("InputDisplayText")]
		public string InputDisplayText { get; set; }

		/// <summary>
		/// Whether the seller input applies to the item or the shipment.
		/// </summary>
		[JsonProperty("InputTarget")]
		public InputTargetType InputTarget { get; set; }

		[IsRequired]
		[JsonProperty("StoredValue")]
		public AdditionalSellerInput StoredValue { get; set; }

		[JsonProperty("RestrictedSetValues")]
		public RestrictedSetValues RestrictedSetValues { get; set; }
	}
}
