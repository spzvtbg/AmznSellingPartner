namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents an MSKU and the related quantity.
	/// </summary>
	public class MskuQuantity : BaseClass
	{
		/// <summary>
		/// The merchant SKU, a merchant-supplied identifier for a specific SKU.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(40)]
		[JsonProperty("msku")]
		public string Msku { get; set; }

		/// <summary>
		/// A positive integer.
		/// </summary>
		[IsRequired]
		[Minimum(1)]
		[Maximum(10000)]
		[JsonProperty("quantity")]
		public int Quantity { get; set; }
	}
}
