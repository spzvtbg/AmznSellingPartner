namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Monetary and tax details of the charge.
	/// </summary>
	public class ChargeDetails : BaseClass
	{
		/// <summary>
		/// Type of charge applied.
		/// </summary>
		[JsonProperty("type")]
		[IsRequired]
		public Type Type { get; set; } 

		[JsonProperty("chargeAmount")]
		[IsRequired]
		public Money ChargeAmount { get; set; } 

		/// <summary>
		/// Individual tax details per line item.
		/// </summary>
		[JsonProperty("taxDetails")]
		public List<TaxDetail> TaxDetails { get; set; } 
	}
}
