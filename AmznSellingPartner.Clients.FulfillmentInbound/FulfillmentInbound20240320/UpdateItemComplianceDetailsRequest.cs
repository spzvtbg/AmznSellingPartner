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
		[IsRequired]
		[MinLength(1)]
		[MaxLength(40)]
		[JsonProperty("msku")]
		public string Msku { get; set; }

		[IsRequired]
		[JsonProperty("taxDetails")]
		public TaxDetails TaxDetails { get; set; }
	}
}
