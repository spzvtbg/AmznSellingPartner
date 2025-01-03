namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Type
	{
		/// <summary>
		/// Tax levied on consumption spending on goods and services.
		/// </summary>
		[EnumMember(Value = "CONSUMPTION")]
		CONSUMPTION,

		/// <summary>
		/// Tax levied on most goods and services sold for domestic consumption.
		/// </summary>
		[EnumMember(Value = "GST")]
		GST,

		/// <summary>
		/// Mehrwertsteuer, MwSt, is German for value-added tax.
		/// </summary>
		[EnumMember(Value = "MwSt.")]
		MwSt_,

		/// <summary>
		/// A provincial sales tax (PST) is imposed on consumers of goods and particular services in many Canadian
		/// provinces.
		/// </summary>
		[EnumMember(Value = "PST")]
		PST,

		/// <summary>
		/// Combined total of all the applicable taxes.
		/// </summary>
		[EnumMember(Value = "TOTAL")]
		TOTAL,

		/// <summary>
		/// Taxe sur la Valeur Ajout&#233;e (TVA) is French for value-added tax.
		/// </summary>
		[EnumMember(Value = "TVA")]
		TVA,

		/// <summary>
		/// Value-added tax.
		/// </summary>
		[EnumMember(Value = "VAT")]
		VAT,
	}
}
