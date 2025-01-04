namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Contains the type and rate of tax.
	/// </summary>
	public class TaxRate : BaseClass
	{
		/// <summary>
		/// Rate of cess tax.
		/// </summary>
		[JsonProperty("cessRate")]
		public double CessRate { get; set; } 

		/// <summary>
		/// Rate of gst tax.
		/// </summary>
		[JsonProperty("gstRate")]
		public double GstRate { get; set; } 

		/// <summary>
		/// Type of tax. Possible values: `CGST`, `SGST`, `IGST`, `TOTAL_TAX`.
		/// </summary>
		[JsonProperty("taxType")]
		[MinLength(1)]
		[MaxLength(1024)]
		public string TaxType { get; set; } 
	}
}
