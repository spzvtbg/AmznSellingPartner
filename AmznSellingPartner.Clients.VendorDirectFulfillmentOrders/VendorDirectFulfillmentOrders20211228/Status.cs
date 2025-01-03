namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Status
	{
		/// <summary>
		/// Status for newly created purchase orders
		/// </summary>
		[EnumMember(Value = "NEW")]
		NEW,

		/// <summary>
		/// Status for purchase orders that are already shipped
		/// </summary>
		[EnumMember(Value = "SHIPPED")]
		SHIPPED,

		/// <summary>
		/// Status for purchase orders accepted by vendors
		/// </summary>
		[EnumMember(Value = "ACCEPTED")]
		ACCEPTED,

		/// <summary>
		/// Status for cancelled purchase orders
		/// </summary>
		[EnumMember(Value = "CANCELLED")]
		CANCELLED,
	}
}
