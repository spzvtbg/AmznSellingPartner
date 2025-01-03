namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortOrder
	{
		/// <summary>
		/// Sort in ascending order by order creation date.
		/// </summary>
		[EnumMember(Value = "ASC")]
		ASC,

		/// <summary>
		/// Sort in descending order by order creation date.
		/// </summary>
		[EnumMember(Value = "DESC")]
		DESC,
	}
}
