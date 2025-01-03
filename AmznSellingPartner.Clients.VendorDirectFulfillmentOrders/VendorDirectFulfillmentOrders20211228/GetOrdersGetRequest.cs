namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	[HttpGet("/vendor/directFulfillment/orders/2021-12-28/purchaseOrders")]
	public class GetOrdersGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The vendor warehouse identifier for the fulfillment warehouse
		/// If not specified, the result will contain orders for all warehouses
		/// </summary>
		[InQuery("shipFromPartyId")]
		[JsonProperty("shipFromPartyId")]
		public string ShipFromPartyId { get; set; }

		/// <summary>
		/// Returns only the purchase orders that match the specified status
		/// If not specified, the result will contain orders that match any status
		/// </summary>
		[InQuery("status")]
		[JsonProperty("status")]
		public Status Status { get; set; }

		/// <summary>
		/// The limit to the number of purchase orders returned
		/// </summary>
		[InQuery("limit")]
		[Minimum(1)]
		[Maximum(100)]
		[JsonProperty("limit")]
		public long Limit { get; set; }

		/// <summary>
		/// Purchase orders that became available after this date and time will be included in the result
		/// Must be in ISO-8601 date/time format
		/// </summary>
		[InQuery("createdAfter")]
		[IsRequired]
		[JsonProperty("createdAfter")]
		public DateTime CreatedAfter { get; set; }

		/// <summary>
		/// Purchase orders that became available before this date and time will be included in the result
		/// Must be in ISO-8601 date/time format
		/// </summary>
		[InQuery("createdBefore")]
		[IsRequired]
		[JsonProperty("createdBefore")]
		public DateTime CreatedBefore { get; set; }

		/// <summary>
		/// Sort the list in ascending or descending order by order creation date
		/// </summary>
		[InQuery("sortOrder")]
		[JsonProperty("sortOrder")]
		public SortOrder SortOrder { get; set; }

		/// <summary>
		/// Used for pagination when there are more orders than the specified result size limit
		/// The token value is returned in the previous API call
		/// </summary>
		[InQuery("nextToken")]
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }

		/// <summary>
		/// When true, returns the complete purchase order details
		/// Otherwise, only purchase order numbers are returned
		/// </summary>
		[InQuery("includeDetails")]
		[JsonProperty("includeDetails")]
		public bool IncludeDetails { get; set; }
	}
}
