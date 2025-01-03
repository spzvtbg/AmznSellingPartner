namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	[HttpGet("/vendor/orders/v1/purchaseOrdersStatus")]
	public class GetPurchaseOrdersStatusGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The limit to the number of records returned. Default value is 100 records.
		/// </summary>
		[InQuery("limit")]
		[Minimum(1)]
		[Maximum(100)]
		[JsonProperty("limit")]
		public long Limit { get; set; }

		/// <summary>
		/// Sort in ascending or descending order by purchase order creation date.
		/// </summary>
		[InQuery("sortOrder")]
		[JsonProperty("sortOrder")]
		public SortOrder SortOrder { get; set; }

		/// <summary>
		/// Used for pagination when there are more purchase orders than the specified result size limit.
		/// </summary>
		[InQuery("nextToken")]
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }

		/// <summary>
		/// Purchase orders that became available after this timestamp will be included in the result. Must be in
		/// ISO-8601 date/time format.
		/// </summary>
		[InQuery("createdAfter")]
		[JsonProperty("createdAfter")]
		public DateTime CreatedAfter { get; set; }

		/// <summary>
		/// Purchase orders that became available before this timestamp will be included in the result. Must be in
		/// ISO-8601 date/time format.
		/// </summary>
		[InQuery("createdBefore")]
		[JsonProperty("createdBefore")]
		public DateTime CreatedBefore { get; set; }

		/// <summary>
		/// Purchase orders for which the last purchase order update happened after this timestamp will be included
		/// in the result. Must be in ISO-8601 date/time format.
		/// </summary>
		[InQuery("updatedAfter")]
		[JsonProperty("updatedAfter")]
		public DateTime UpdatedAfter { get; set; }

		/// <summary>
		/// Purchase orders for which the last purchase order update happened before this timestamp will be included
		/// in the result. Must be in ISO-8601 date/time format.
		/// </summary>
		[InQuery("updatedBefore")]
		[JsonProperty("updatedBefore")]
		public DateTime UpdatedBefore { get; set; }

		/// <summary>
		/// Provides purchase order status for the specified purchase order number.
		/// </summary>
		[InQuery("purchaseOrderNumber")]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Filters purchase orders based on the specified purchase order status. If not included in filter, this
		/// will return purchase orders for all statuses.
		/// </summary>
		[InQuery("purchaseOrderStatus")]
		[JsonProperty("purchaseOrderStatus")]
		public PurchaseOrderStatus PurchaseOrderStatus { get; set; }

		/// <summary>
		/// Filters purchase orders based on their item confirmation status. If the item confirmation status is not
		/// included in the filter, purchase orders for all confirmation statuses are included.
		/// </summary>
		[InQuery("itemConfirmationStatus")]
		[JsonProperty("itemConfirmationStatus")]
		public ItemConfirmationStatus ItemConfirmationStatus { get; set; }

		/// <summary>
		/// Filters purchase orders based on the purchase order's item receive status. If the item receive status
		/// is not included in the filter, purchase orders for all receive statuses are included.
		/// </summary>
		[InQuery("itemReceiveStatus")]
		[JsonProperty("itemReceiveStatus")]
		public ItemReceiveStatus ItemReceiveStatus { get; set; }

		/// <summary>
		/// Filters purchase orders based on the specified ordering vendor code. This value should be same as 'sellingParty.partyId'
		/// in the purchase order. If not included in filter, all purchase orders for all the vendor codes that exist
		/// in the vendor group used to authorize API client application are returned.
		/// </summary>
		[InQuery("orderingVendorCode")]
		[JsonProperty("orderingVendorCode")]
		public string OrderingVendorCode { get; set; }

		/// <summary>
		/// Filters purchase orders for a specific buyer's Fulfillment Center/warehouse by providing ship to location
		/// id here. This value should be same as 'shipToParty.partyId' in the purchase order. If not included in
		/// filter, this will return purchase orders for all the buyer's warehouses used for vendor group purchase
		/// orders.
		/// </summary>
		[InQuery("shipToPartyId")]
		[JsonProperty("shipToPartyId")]
		public string ShipToPartyId { get; set; }
	}
}
