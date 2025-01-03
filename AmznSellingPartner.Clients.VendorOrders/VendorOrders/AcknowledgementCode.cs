namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum AcknowledgementCode
	{
		/// <summary>
		/// Vendor accepts to fulfill the order item(s)
		/// </summary>
		[EnumMember(Value = "Accepted")]
		Accepted,

		/// <summary>
		/// Vendor placed a backorder to fulfill the original order and provides a scheduledShipDate or scheduledDeliveryD
		/// te which is different than the expectedShipDate or expectedDeliveryDate provided in the purchase order
		/// </summary>
		[EnumMember(Value = "Backordered")]
		Backordered,

		/// <summary>
		/// Vendor rejects to fulfill the order item(s)
		/// </summary>
		[EnumMember(Value = "Rejected")]
		Rejected,
	}
}
