namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum TaxType
	{
		/// <summary>
		/// Central Goods and Services Tax (CGST) is levied by the Indian government for intrastate movement of goods and
		/// ervices
		/// </summary>
		[EnumMember(Value = "CGST")]
		CGST,

		/// <summary>
		/// State Goods and Services Tax (SGST) is an indirect tax levied and collected by a State Government in India on
		/// he intra-state supplies
		/// </summary>
		[EnumMember(Value = "SGST")]
		SGST,

		/// <summary>
		/// A CESS is a form of tax levied by the government on tax with specific purposes till the time the government ge
		/// s enough money for that purpose
		/// </summary>
		[EnumMember(Value = "CESS")]
		CESS,

		/// <summary>
		/// Union Territory Goods and Services Tax in India
		/// </summary>
		[EnumMember(Value = "UTGST")]
		UTGST,

		/// <summary>
		/// Integrated Goods and Services Tax (IGST) is a tax levied on all Inter-State supplies of goods and/or services
		/// n India
		/// </summary>
		[EnumMember(Value = "IGST")]
		IGST,

		/// <summary>
		/// Mehrwertsteuer, MwSt, is German for value-added tax
		/// </summary>
		[EnumMember(Value = "MwSt.")]
		MwSt_,

		/// <summary>
		/// A provincial sales tax (PST) is imposed on consumers of goods and particular services in many Canadian provinc
		/// s
		/// </summary>
		[EnumMember(Value = "PST")]
		PST,

		/// <summary>
		/// Taxe sur la Valeur Ajout&#233;e (TVA) is French for value-added tax
		/// </summary>
		[EnumMember(Value = "TVA")]
		TVA,

		/// <summary>
		/// Value-added tax
		/// </summary>
		[EnumMember(Value = "VAT")]
		VAT,

		/// <summary>
		/// Tax levied on most goods and services sold for domestic consumption
		/// </summary>
		[EnumMember(Value = "GST")]
		GST,

		/// <summary>
		/// Sales tax
		/// </summary>
		[EnumMember(Value = "ST")]
		ST,

		/// <summary>
		/// Tax levied on consumption spending on goods and services
		/// </summary>
		[EnumMember(Value = "Consumption")]
		Consumption,

		/// <summary>
		/// Tax component that was mutually agreed upon between Amazon and vendor
		/// </summary>
		[EnumMember(Value = "MutuallyDefined")]
		MutuallyDefined,

		/// <summary>
		/// Domestic value-added tax
		/// </summary>
		[EnumMember(Value = "DomesticVAT")]
		DomesticVAT,
	}
}
