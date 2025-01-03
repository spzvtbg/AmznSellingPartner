namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum PurchaseOrderType
	{
		/// <summary>
		/// A regular purchase order is a method for placing orders for a one-time purchase and payment for line item good
		/// that have a specific quantity and unit price
		/// </summary>
		[EnumMember(Value = "RegularOrder")]
		RegularOrder,

		/// <summary>
		/// A consignment purchase order is an agreement with a vendor that allows the product to be received, but the inv
		/// ntory still belong to the vendor until the product is used
		/// </summary>
		[EnumMember(Value = "ConsignedOrder")]
		ConsignedOrder,

		/// <summary>
		/// A purchase order where a new product is introduced
		/// </summary>
		[EnumMember(Value = "NewProductIntroduction")]
		NewProductIntroduction,

		/// <summary>
		/// Rush orders are purchases of goods that need to be processed and delivered by a certain date that is much soon
		/// r than the standard arrival date
		/// </summary>
		[EnumMember(Value = "RushOrder")]
		RushOrder,
	}
}
