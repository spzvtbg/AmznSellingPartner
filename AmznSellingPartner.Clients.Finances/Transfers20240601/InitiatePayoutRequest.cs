namespace AmznSellingPartner.Clients.Finances.Transfers20240601
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the `initiatePayout` operation.
	/// </summary>
	public class InitiatePayoutRequest : BaseClass
	{
		/// <summary>
		/// The identifier of the Amazon marketplace. This API supports the following marketplaces: DE, FR, IT, ES,
		/// SE, NL, PL, and BE. For a list of possible marketplace IDs, refer to [Marketplace IDs](https://devel
		/// oper-docs.amazon.com/sp-api/docs/marketplace-ids).
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public MarketplaceId MarketplaceId { get; set; }

		/// <summary>
		/// The account type in the selected marketplace for which a payout must be initiated. For supported EU marketplaces,
		/// the only account type is `Standard Orders`.
		/// </summary>
		[IsRequired]
		[JsonProperty("accountType")]
		public string AccountType { get; set; }
	}
}
