namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Tax information about the buyer
	/// </summary>
	public class BuyerTaxInfo : BaseClass
	{
		/// <summary>
		/// The legal name of the company
		/// </summary>
		[JsonProperty("CompanyLegalName")]
		public string CompanyLegalName { get; set; }

		/// <summary>
		/// The country or region imposing the tax
		/// </summary>
		[JsonProperty("TaxingRegion")]
		public string TaxingRegion { get; set; }

		/// <summary>
		/// A list of tax classifications that apply to the order
		/// </summary>
		[JsonProperty("TaxClassifications")]
		public List<TaxClassification> TaxClassifications { get; set; }
	}
}
