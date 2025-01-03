namespace AmznSellingPartner.Clients.VendorDirectFulfillmentPayments.VendorDirectFulfillmentPaymentsV1
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
		/// Type of charge applied
		/// </summary>
		[IsRequired]
		[JsonProperty("type")]
		public Type Type { get; set; }

		[IsRequired]
		[JsonProperty("chargeAmount")]
		public Money ChargeAmount { get; set; }

		/// <summary>
		/// Individual tax details per line item
		/// </summary>
		[JsonProperty("taxDetails")]
		public List<TaxDetail> TaxDetails { get; set; }
	}
}
