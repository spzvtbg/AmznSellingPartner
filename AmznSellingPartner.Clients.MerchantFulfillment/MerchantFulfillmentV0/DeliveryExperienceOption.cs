namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The delivery confirmation level.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DeliveryExperienceOption
	{
		/// <summary>
		/// Delivery confirmation with adult signature.
		/// </summary>
		[EnumMember(Value = "DeliveryConfirmationWithAdultSignature")]
		DeliveryConfirmationWithAdultSignature,

		/// <summary>
		/// Delivery confirmation with signature. Required for DPD (UK).
		/// </summary>
		[EnumMember(Value = "DeliveryConfirmationWithSignature")]
		DeliveryConfirmationWithSignature,

		/// <summary>
		/// Delivery confirmation without signature.
		/// </summary>
		[EnumMember(Value = "DeliveryConfirmationWithoutSignature")]
		DeliveryConfirmationWithoutSignature,

		/// <summary>
		/// No delivery confirmation.
		/// </summary>
		[EnumMember(Value = "NoTracking")]
		NoTracking,

		/// <summary>
		/// No preference.
		/// </summary>
		[EnumMember(Value = "NoPreference")]
		NoPreference,
	}
}
