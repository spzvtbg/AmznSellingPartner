namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	[HttpGet("/vendor/directFulfillment/shipping/2021-12-28/packingSlips")]
	public class GetPackingSlipsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The vendor `warehouseId` for order fulfillment. If not specified, the result contains orders for all warehouse
		/// .
		/// </summary>
		[InQuery("shipFromPartyId")]
		[JsonProperty("shipFromPartyId")]
		public string ShipFromPartyId { get; set; }

		/// <summary>
		/// The maximum number of records to return.
		/// </summary>
		[InQuery("limit")]
		[Minimum(1)]
		[Maximum(100)]
		[JsonProperty("limit")]
		public int Limit { get; set; }

		/// <summary>
		/// Packing slips that become available after this date and time will be included in the result. Values are in [IS
		/// 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
		/// </summary>
		[InQuery("createdAfter")]
		[IsRequired]
		[JsonProperty("createdAfter")]
		public DateTime CreatedAfter { get; set; }

		/// <summary>
		/// Packing slips that became available before this date and time will be included in the result. Values are in [I
		/// O 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
		/// </summary>
		[InQuery("createdBefore")]
		[IsRequired]
		[JsonProperty("createdBefore")]
		public DateTime CreatedBefore { get; set; }

		/// <summary>
		/// The packing slip creation dates, which are sorted by ascending or descending order.
		/// </summary>
		[InQuery("sortOrder")]
		[JsonProperty("sortOrder")]
		public SortOrder SortOrder { get; set; }

		/// <summary>
		/// Used for pagination when there are more packing slips than the specified result size limit. The token value is
		/// returned in the previous API call.
		/// </summary>
		[InQuery("nextToken")]
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
