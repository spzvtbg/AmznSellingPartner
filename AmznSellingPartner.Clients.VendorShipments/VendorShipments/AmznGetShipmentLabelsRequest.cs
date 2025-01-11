namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/vendor/shipping/v1/transportLabels")]
	public class AmznGetShipmentLabelsRequest : BaseHttpRequest
	{
		/// <summary>
		/// The limit to the number of records returned. Default value is 50 records.
		/// </summary>
		[InQuery("limit")]
		[Minimum(1)]
		[Maximum(50)]
		public long Limit { get; set; } 

		/// <summary>
		/// Sort the list by shipment label creation date in ascending or descending order.
		/// </summary>
		[InQuery("sortOrder")]
		public SortOrder SortOrder { get; set; } 

		/// <summary>
		/// A token that is used to retrieve the next page of results. The response includes `nextToken`
		/// when the number of results exceeds the specified `pageSize` value. To get the next page of
		/// results, call the operation with this token and include the same arguments as the call that
		/// produced the token. To get a complete list, call this operation until `nextToken` is null.
		/// Note that this operation can return empty pages.
		/// </summary>
		[InQuery("nextToken")]
		public string NextToken { get; set; } 

		/// <summary>
		/// Shipment labels created after this time will be included in the result. This field must be
		/// in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format.
		/// </summary>
		[InQuery("labelCreatedAfter")]
		public DateTimeValue LabelCreatedAfter { get; set; } 

		/// <summary>
		/// Shipment labels created before this time will be included in the result. This field must be
		/// in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format.
		/// </summary>
		[InQuery("labelCreatedBefore")]
		public DateTimeValue LabelCreatedBefore { get; set; } 

		/// <summary>
		/// Get Shipment labels by passing buyer reference number.
		/// </summary>
		[InQuery("buyerReferenceNumber")]
		public string BuyerReferenceNumber { get; set; } 

		/// <summary>
		/// Get Shipment labels by passing vendor shipment identifier.
		/// </summary>
		[InQuery("vendorShipmentIdentifier")]
		public string VendorShipmentIdentifier { get; set; } 

		/// <summary>
		/// Get Shipping labels based on vendor warehouse code. This value must be same as the `sellingParty.partyId`
		/// in the shipment.
		/// </summary>
		[InQuery("sellerWarehouseCode")]
		public string SellerWarehouseCode { get; set; } 
	}
}
