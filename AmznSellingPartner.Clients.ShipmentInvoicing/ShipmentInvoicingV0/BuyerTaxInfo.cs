namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using Newtonsoft.Json;

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

		[JsonProperty("TaxClassifications")]
		public TaxClassificationList TaxClassifications { get; set; }
	}
}
