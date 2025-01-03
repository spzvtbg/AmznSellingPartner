namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum PurchaseOrderState
	{
		/// <summary>
		/// Status of the orders that are newly created
		/// </summary>
		[EnumMember(Value = "New")]
		New,

		/// <summary>
		/// Status of the orders acknowledged by vendors
		/// </summary>
		[EnumMember(Value = "Acknowledged")]
		Acknowledged,

		/// <summary>
		/// Status of the orders that are completed
		/// </summary>
		[EnumMember(Value = "Closed")]
		Closed,
	}
}
