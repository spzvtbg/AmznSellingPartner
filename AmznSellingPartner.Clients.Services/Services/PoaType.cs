namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum PoaType
	{
		/// <summary>
		/// Indicates that the type of proof of appointment uploaded is a dummy signature
		/// </summary>
		[EnumMember(Value = "NO_SIGNATURE_DUMMY_POS")]
		NO_SIGNATURE_DUMMY_POS,

		/// <summary>
		/// Indicates that the type of proof of appointment uploaded is a customer signature
		/// </summary>
		[EnumMember(Value = "CUSTOMER_SIGNATURE")]
		CUSTOMER_SIGNATURE,

		/// <summary>
		/// Indicates that the type of proof of appointment uploaded is a dummy receipt
		/// </summary>
		[EnumMember(Value = "DUMMY_RECEIPT")]
		DUMMY_RECEIPT,

		/// <summary>
		/// Indicates that the type of proof of appointment is a receipt
		/// </summary>
		[EnumMember(Value = "POA_RECEIPT")]
		POA_RECEIPT,
	}
}
