namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ItemReceiveStatus
	{
		/// <summary>
		/// Provides a list of orders that have at least one item not received by the buyer.
		/// </summary>
		[EnumMember(Value = "NOT_RECEIVED")]
		NOT_RECEIVED,

		/// <summary>
		/// Provides a list of orders that have at least one item not received by the buyer.
		/// </summary>
		[EnumMember(Value = "PARTIALLY_RECEIVED")]
		PARTIALLY_RECEIVED,

		/// <summary>
		/// Provides a list of orders that have at least one item fully received by the buyer.
		/// </summary>
		[EnumMember(Value = "RECEIVED")]
		RECEIVED,
	}
}
