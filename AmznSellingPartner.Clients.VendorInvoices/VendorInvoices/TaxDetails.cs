namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Details of tax amount applied.
	/// </summary>
	public class TaxDetails : BaseClass
	{
		/// <summary>
		/// Type of the tax applied.
		/// </summary>
		[JsonProperty("taxType")]
		[IsRequired]
		public TaxType TaxType { get; set; } 

		/// <summary>
		/// Tax percentage applied. Percentage must be expressed in decimal.
		/// </summary>
		[JsonProperty("taxRate")]
		public Decimal TaxRate { get; set; } 

		/// <summary>
		/// Total tax amount applied on invoice total or an item total.
		/// </summary>
		[JsonProperty("taxAmount")]
		[IsRequired]
		public Money TaxAmount { get; set; } 

		/// <summary>
		/// The invoice amount that is taxable at the rate specified in the tax rate field.
		/// </summary>
		[JsonProperty("taxableAmount")]
		public Money TaxableAmount { get; set; } 
	}
}
