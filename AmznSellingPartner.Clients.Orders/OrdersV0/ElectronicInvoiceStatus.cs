namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The status of the electronic invoice. Only available for Easy Ship orders and orders in the BR marketplace.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ElectronicInvoiceStatus
	{
		/// <summary>
		/// The order does not require an electronic invoice to be uploaded.
		/// </summary>
		[EnumMember(Value = "NotRequired")]
		NotRequired,

		/// <summary>
		/// The order requires an electronic invoice but it is not uploaded.
		/// </summary>
		[EnumMember(Value = "NotFound")]
		NotFound,

		/// <summary>
		/// The required electronic invoice was uploaded and is processing.
		/// </summary>
		[EnumMember(Value = "Processing")]
		Processing,

		/// <summary>
		/// The uploaded electronic invoice was not accepted.
		/// </summary>
		[EnumMember(Value = "Errored")]
		Errored,

		/// <summary>
		/// The uploaded electronic invoice was accepted.
		/// </summary>
		[EnumMember(Value = "Accepted")]
		Accepted,
	}
}
