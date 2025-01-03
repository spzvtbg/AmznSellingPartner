namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum PaymentMethod
	{
		/// <summary>
		/// An invoice payment is submitted by a business to pay for products and services purchased from vendor
		/// s.
		/// </summary>
		[EnumMember(Value = "Invoice")]
		Invoice,

		/// <summary>
		/// A retail merchandiser acts as a consignor for goods supplied by the consignee. The consignor pays the
		/// consignee after the sale and keeps a percentage of the proceeds
		/// </summary>
		[EnumMember(Value = "Consignment")]
		Consignment,

		/// <summary>
		/// Payment is made using a credit card.
		/// </summary>
		[EnumMember(Value = "CreditCard")]
		CreditCard,

		/// <summary>
		/// Payment is prepaid.
		/// </summary>
		[EnumMember(Value = "Prepaid")]
		Prepaid,
	}
}
