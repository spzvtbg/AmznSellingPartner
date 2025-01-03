namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum RejectionReason
	{
		/// <summary>
		/// Items are currently not available.
		/// </summary>
		[EnumMember(Value = "TemporarilyUnavailable")]
		TemporarilyUnavailable,

		/// <summary>
		/// Item cannot be found with the provided identifier.
		/// </summary>
		[EnumMember(Value = "InvalidProductIdentifier")]
		InvalidProductIdentifier,

		/// <summary>
		/// Item is no longer sold.
		/// </summary>
		[EnumMember(Value = "ObsoleteProduct")]
		ObsoleteProduct,
	}
}
