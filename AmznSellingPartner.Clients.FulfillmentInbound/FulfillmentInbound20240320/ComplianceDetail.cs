namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Contains item identifiers and related tax information.
	/// </summary>
	public class ComplianceDetail : BaseClass
	{
		/// <summary>
		/// The Amazon Standard Identification Number, which identifies the detail page identifier.
		/// </summary>
		[MinLength(1)]
		[MaxLength(10)]
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		/// The Fulfillment Network SKU, which identifies a real fulfillable item with catalog data and conditio
		/// n.
		/// </summary>
		[MinLength(1)]
		[MaxLength(10)]
		[JsonProperty("fnsku")]
		public string Fnsku { get; set; }

		/// <summary>
		/// The merchant SKU, a merchant-supplied identifier for a specific SKU.
		/// </summary>
		[MinLength(1)]
		[MaxLength(40)]
		[JsonProperty("msku")]
		public string Msku { get; set; }

		[JsonProperty("taxDetails")]
		public TaxDetails TaxDetails { get; set; }
	}
}
