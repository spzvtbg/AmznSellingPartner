namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `setPrepDetails` request.
	/// </summary>
	public class SetPrepDetailsRequest : BaseClass
	{
		/// <summary>
		/// The marketplace ID. For a list of possible values, refer to [Marketplace IDs](https://developer-docs
		/// .amazon.com/sp-api/docs/marketplace-ids).
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(20)]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// A list of MSKUs and related prep details.
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[MaxItems(100)]
		[JsonProperty("mskuPrepDetails")]
		public List<MskuPrepDetailInput> MskuPrepDetails { get; set; }
	}
}
