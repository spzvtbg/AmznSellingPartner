namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum PurchaseOrderStatus
	{
		/// <summary>
		/// Buyer has not yet received all of the items in the purchase order
		/// </summary>
		[EnumMember(Value = "OPEN")]
		OPEN,

		/// <summary>
		/// Buyer has received all of the items in the purchase order
		/// </summary>
		[EnumMember(Value = "CLOSED")]
		CLOSED,
	}
}
