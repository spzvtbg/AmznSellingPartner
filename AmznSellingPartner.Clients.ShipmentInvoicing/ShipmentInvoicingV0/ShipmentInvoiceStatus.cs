namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The shipment invoice status
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShipmentInvoiceStatus
	{
		/// <summary>
		/// The invoice validation process is in progress
		/// </summary>
		[EnumMember(Value = "Processing")]
		Processing,

		/// <summary>
		/// The invoice validation process succeeded, and the invoice was successfully ingested
		/// </summary>
		[EnumMember(Value = "Accepted")]
		Accepted,

		/// <summary>
		/// The invoice validation process failed
		/// </summary>
		[EnumMember(Value = "Errored")]
		Errored,

		/// <summary>
		/// The requested invoice was not found
		/// </summary>
		[EnumMember(Value = "NotFound")]
		NotFound,
	}
}
