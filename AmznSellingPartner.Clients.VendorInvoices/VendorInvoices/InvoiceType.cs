namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum InvoiceType
	{
		/// <summary>
		/// A commercial document issued by a seller to a buyer, relating to a sale transaction and indicating the
		/// products, quantities, and agreed prices for products or services the seller had provided the buyer.
		/// </summary>
		[EnumMember(Value = "Invoice")]
		Invoice,

		/// <summary>
		/// A commercial document issued by a seller to a buyer. It is evidence of the reduction in sales.
		/// </summary>
		[EnumMember(Value = "CreditNote")]
		CreditNote,
	}
}
