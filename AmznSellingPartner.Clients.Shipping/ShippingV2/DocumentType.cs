namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The type of shipping document.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DocumentType
	{
		/// <summary>
		/// A listing of the items packed within the shipment.
		/// </summary>
		[EnumMember(Value = "PACKSLIP")]
		PACKSLIP,

		/// <summary>
		/// The shipping label for the specific shipment.
		/// </summary>
		[EnumMember(Value = "LABEL")]
		LABEL,

		/// <summary>
		/// The receipt of the shipment.
		/// </summary>
		[EnumMember(Value = "RECEIPT")]
		RECEIPT,

		/// <summary>
		/// The customs documentation for a cross-border shipment.
		/// </summary>
		[EnumMember(Value = "CUSTOM_FORM")]
		CUSTOM_FORM,
	}
}
