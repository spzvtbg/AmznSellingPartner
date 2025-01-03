namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	using System;

	[HttpGet("/fba/inventory/v1/summaries")]
	public class GetInventorySummariesGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// true to return inventory summaries with additional summarized inventory details and quantities. Otherwise, ret
		/// rns inventory summaries only (default value).
		/// </summary>
		[InQuery("details")]
		[JsonProperty("details")]
		public bool Details { get; set; }

		/// <summary>
		/// The granularity type for the inventory aggregation level.
		/// </summary>
		[InQuery("granularityType")]
		[IsRequired]
		[JsonProperty("granularityType")]
		public GranularityType GranularityType { get; set; }

		/// <summary>
		/// The granularity ID for the inventory aggregation level.
		/// </summary>
		[InQuery("granularityId")]
		[IsRequired]
		[JsonProperty("granularityId")]
		public string GranularityId { get; set; }

		/// <summary>
		/// A start date and time in ISO8601 format. If specified, all inventory summaries that have changed since then ar
		/// returned. You must specify a date and time that is no earlier than 18 months prior to the date and time when
		/// ou call the API. Note: Changes in inboundWorkingQuantity, inboundShippedQuantity and inboundReceivingQuantity
		/// re not detected.
		/// </summary>
		[InQuery("startDateTime")]
		[JsonProperty("startDateTime")]
		public DateTime StartDateTime { get; set; }

		/// <summary>
		/// A list of seller SKUs for which to return inventory summaries. You may specify up to 50 SKUs.
		/// </summary>
		[InQuery("sellerSkus")]
		[MaxItems(50)]
		[JsonProperty("sellerSkus")]
		public CsvValue<string> SellerSkus { get; set; }

		/// <summary>
		/// A single seller SKU used for querying the specified seller SKU inventory summaries.
		/// </summary>
		[InQuery("sellerSku")]
		[JsonProperty("sellerSku")]
		public string SellerSku { get; set; }

		/// <summary>
		/// String token returned in the response of your previous request. The string token will expire 30 seconds after
		/// eing created.
		/// </summary>
		[InQuery("nextToken")]
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }

		/// <summary>
		/// The marketplace ID for the marketplace for which to return inventory summaries.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }
	}
}
