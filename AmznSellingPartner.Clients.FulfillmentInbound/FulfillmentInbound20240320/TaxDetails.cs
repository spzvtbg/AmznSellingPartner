namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Information used to determine the tax compliance.
	/// </summary>
	public class TaxDetails : BaseClass
	{
		[JsonProperty("declaredValue")]
		public Currency DeclaredValue { get; set; } 

		/// <summary>
		/// Harmonized System of Nomenclature code.
		/// </summary>
		[JsonProperty("hsnCode")]
		[MinLength(1)]
		[MaxLength(1024)]
		public string HsnCode { get; set; } 

		/// <summary>
		/// List of tax rates.
		/// </summary>
		[JsonProperty("taxRates")]
		public List<TaxRate> TaxRates { get; set; } 
	}
}
