namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Info About CarrierAccountInput
	/// </summary>
	public class CarrierAccountInput : BaseClass
	{
		/// <summary>
		/// descriptionLocalizationKey value
		/// </summary>
		[JsonProperty("descriptionLocalizationKey")]
		public string DescriptionLocalizationKey { get; set; }

		/// <summary>
		/// name value
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// groupName value
		/// </summary>
		[JsonProperty("groupName")]
		public string GroupName { get; set; }

		[JsonProperty("inputType")]
		public InputType InputType { get; set; }

		/// <summary>
		/// mandatory or not  value
		/// </summary>
		[JsonProperty("isMandatory")]
		public bool IsMandatory { get; set; }

		/// <summary>
		/// is value is Confidential
		/// </summary>
		[JsonProperty("isConfidential")]
		public bool IsConfidential { get; set; }

		/// <summary>
		/// is value is hidden
		/// </summary>
		[JsonProperty("isHidden")]
		public bool IsHidden { get; set; }

		[JsonProperty("validationMetadata")]
		public ValidationMetadataList ValidationMetadata { get; set; }
	}
}
