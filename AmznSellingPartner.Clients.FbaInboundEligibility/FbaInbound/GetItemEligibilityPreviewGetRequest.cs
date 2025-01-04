namespace AmznSellingPartner.Clients.FbaInboundEligibility.FbaInbound
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/fba/inbound/v1/eligibility/itemPreview")]
	public class GetItemEligibilityPreviewGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier for the marketplace in which you want to determine eligibility. Required only when pr
		/// ogram=INBOUND.
		/// </summary>
		[InQuery("marketplaceIds")]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// The ASIN of the item for which you want an eligibility preview.
		/// </summary>
		[InQuery("asin")]
		[IsRequired]
		public string Asin { get; set; }

		/// <summary>
		/// The program that you want to check eligibility against.
		/// </summary>
		[InQuery("program")]
		[IsRequired]
		public Program Program { get; set; }
	}
}
