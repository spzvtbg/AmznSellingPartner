namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ItemConfirmationStatus
	{
		/// <summary>
		/// Provides a list of orders that has at least one item fully accepted by vendors.
		/// </summary>
		[EnumMember(Value = "ACCEPTED")]
		ACCEPTED,

		/// <summary>
		/// Provides a list of orders that has at least one item partially accepted by vendors.
		/// </summary>
		[EnumMember(Value = "PARTIALLY_ACCEPTED")]
		PARTIALLY_ACCEPTED,

		/// <summary>
		/// Provides a list of orders that has at least one item rejected by vendors.
		/// </summary>
		[EnumMember(Value = "REJECTED")]
		REJECTED,

		/// <summary>
		/// Provides a list of orders that has at least one item yet to be confirmed by vendors.
		/// </summary>
		[EnumMember(Value = "UNCONFIRMED")]
		UNCONFIRMED,
	}
}
