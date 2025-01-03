namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The tax details related to the order.
	/// </summary>
	public class TaxDetails : BaseClass
	{
		[JsonProperty("taxRate")]
		public Decimal TaxRate { get; set; }

		[IsRequired]
		[JsonProperty("taxAmount")]
		public Money TaxAmount { get; set; }

		[JsonProperty("taxableAmount")]
		public Money TaxableAmount { get; set; }

		/// <summary>
		/// Tax type.
		/// </summary>
		[JsonProperty("type")]
		public Type Type { get; set; }
	}
}
