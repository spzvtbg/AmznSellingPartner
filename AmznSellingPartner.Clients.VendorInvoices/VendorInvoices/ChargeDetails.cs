namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Monetary and tax details of the charge
	/// </summary>
	public class ChargeDetails : BaseClass
	{
		/// <summary>
		/// Type of the charge applied
		/// </summary>
		[IsRequired]
		[JsonProperty("type")]
		public Type Type { get; set; }

		/// <summary>
		/// Description of the charge
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// Total monetary amount related to this charge
		/// </summary>
		[IsRequired]
		[JsonProperty("chargeAmount")]
		public Money ChargeAmount { get; set; }

		/// <summary>
		/// Tax amount details applied on this charge
		/// </summary>
		[JsonProperty("taxDetails")]
		public List<TaxDetails> TaxDetails { get; set; }
	}
}
