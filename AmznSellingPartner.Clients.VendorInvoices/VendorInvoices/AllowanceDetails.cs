namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Monetary and tax details of the allowance.
	/// </summary>
	public class AllowanceDetails : BaseClass
	{
		/// <summary>
		/// Type of the allowance applied.
		/// </summary>
		[IsRequired]
		[JsonProperty("type")]
		public Type Type { get; set; }

		/// <summary>
		/// Description of the allowance.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// Total monetary amount related to this allowance.
		/// </summary>
		[IsRequired]
		[JsonProperty("allowanceAmount")]
		public Money AllowanceAmount { get; set; }

		/// <summary>
		/// Tax amount details applied on this allowance.
		/// </summary>
		[JsonProperty("taxDetails")]
		public List<TaxDetails> TaxDetails { get; set; }
	}
}
