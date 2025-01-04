namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using System;

	[HttpGet("/vendor/orders/v1/purchaseOrders")]
	public class GetPurchaseOrdersGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The limit to the number of records returned. Default value is 100 records.
		/// </summary>
		[InQuery("limit")]
		[Minimum(1)]
		[Maximum(100)]
		public long Limit { get; set; }

		/// <summary>
		/// Purchase orders that became available after this time will be included in the result. Must be in ISO-8601
		/// date/time format.
		/// </summary>
		[InQuery("createdAfter")]
		public DateTime CreatedAfter { get; set; }

		/// <summary>
		/// Purchase orders that became available before this time will be included in the result. Must be in ISO-8601
		/// date/time format.
		/// </summary>
		[InQuery("createdBefore")]
		public DateTime CreatedBefore { get; set; }

		/// <summary>
		/// Sort in ascending or descending order by purchase order creation date.
		/// </summary>
		[InQuery("sortOrder")]
		public SortOrder SortOrder { get; set; }

		/// <summary>
		/// Used for pagination when there is more purchase orders than the specified result size limit. The token
		/// value is returned in the previous API call
		/// </summary>
		[InQuery("nextToken")]
		public string NextToken { get; set; }

		/// <summary>
		/// When true, returns purchase orders with complete details. Otherwise, only purchase order numbers are
		/// returned. Default value is true.
		/// </summary>
		[InQuery("includeDetails")]
		public bool IncludeDetails { get; set; }

		/// <summary>
		/// Purchase orders that changed after this timestamp will be included in the result. Must be in ISO-8601
		/// date/time format.
		/// </summary>
		[InQuery("changedAfter")]
		public DateTime ChangedAfter { get; set; }

		/// <summary>
		/// Purchase orders that changed before this timestamp will be included in the result. Must be in ISO-8601
		/// date/time format.
		/// </summary>
		[InQuery("changedBefore")]
		public DateTime ChangedBefore { get; set; }

		/// <summary>
		/// Current state of the purchase order item. If this value is Cancelled, this API will return purchase orders
		/// which have one or more items cancelled by Amazon with updated item quantity as zero.
		/// </summary>
		[InQuery("poItemState")]
		public PoItemState PoItemState { get; set; }

		/// <summary>
		/// When true, returns purchase orders which were modified after the order was placed. Vendors are required
		/// to pull the changed purchase order and fulfill the updated purchase order and not the original one. Default
		/// value is false.
		/// </summary>
		[InQuery("isPOChanged")]
		public bool IsPOChanged { get; set; }

		/// <summary>
		/// Filters purchase orders based on the purchase order state.
		/// </summary>
		[InQuery("purchaseOrderState")]
		public PurchaseOrderState PurchaseOrderState { get; set; }

		/// <summary>
		/// Filters purchase orders based on the specified ordering vendor code. This value should be same as 'sellingParty.partyId'
		/// in the purchase order. If not included in the filter, all purchase orders for all of the vendor codes
		/// that exist in the vendor group used to authorize the API client application are returned.
		/// </summary>
		[InQuery("orderingVendorCode")]
		public string OrderingVendorCode { get; set; }
	}
}
