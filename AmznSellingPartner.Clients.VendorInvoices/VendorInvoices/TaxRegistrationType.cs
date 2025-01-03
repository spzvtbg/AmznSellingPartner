namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum TaxRegistrationType
	{
		/// <summary>
		/// Value-added tax
		/// </summary>
		[EnumMember(Value = "VAT")]
		VAT,

		/// <summary>
		/// Goods and services tax
		/// </summary>
		[EnumMember(Value = "GST")]
		GST,
	}
}
