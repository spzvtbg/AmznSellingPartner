namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	[HttpGet("/vendor/directFulfillment/shipping/2021-12-28/shippingLabels")]
	public class GetShippingLabelsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The vendor `warehouseId` for order fulfillment. If not specified, the result contains orders for all
		/// warehouses.
		/// </summary>
		[InQuery("shipFromPartyId")]
		[JsonProperty("shipFromPartyId")]
		public string ShipFromPartyId { get; set; }

		/// <summary>
		/// The limit to the number of records returned.
		/// </summary>
		[InQuery("limit")]
		[Minimum(1)]
		[Maximum(100)]
		[JsonProperty("limit")]
		public int Limit { get; set; }

		/// <summary>
		/// Shipping labels that became available after this date and time will be included in the result. Values
		/// are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
		/// </summary>
		[InQuery("createdAfter")]
		[IsRequired]
		[JsonProperty("createdAfter")]
		public DateTime CreatedAfter { get; set; }

		/// <summary>
		/// Shipping labels that became available before this date and time will be included in the result. Values
		/// are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) date-time format.
		/// </summary>
		[InQuery("createdBefore")]
		[IsRequired]
		[JsonProperty("createdBefore")]
		public DateTime CreatedBefore { get; set; }

		/// <summary>
		/// The sort order creation date. You can choose between ascending (`ASC`) or descending (`DESC`) sort o
		/// rder.
		/// </summary>
		[InQuery("sortOrder")]
		[JsonProperty("sortOrder")]
		public SortOrder SortOrder { get; set; }

		/// <summary>
		/// Used for pagination when there are more ship labels than the specified result size limit. The token value
		/// is returned in the previous API call.
		/// </summary>
		[InQuery("nextToken")]
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
