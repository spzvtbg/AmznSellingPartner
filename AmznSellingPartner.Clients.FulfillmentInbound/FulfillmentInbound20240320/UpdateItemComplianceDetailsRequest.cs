namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `updateItemComplianceDetails` request.
	/// </summary>
	public class UpdateItemComplianceDetailsRequest : BaseClass
	{
		/// <summary>
		/// The merchant SKU, a merchant-supplied identifier for a specific SKU.
		/// </summary>
		[JsonProperty("msku")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(40)]
		public string Msku { get; set; }

		[JsonProperty("taxDetails")]
		[IsRequired]
		public TaxDetails TaxDetails { get; set; }
	}
}
