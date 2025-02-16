namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpGet("/awd/2024-05-09/inboundShipments")]
    public class AmznListInboundShipmentsRequest : BaseHttpRequest
    {
        /// <summary>
        /// Field to sort results by. By default, the response will be sorted by UPDATED_AT.
        /// </summary>
        [InQuery("sortBy")]
        public SortBy SortBy { get; set; }

        /// <summary>
        /// Sort the response in ASCENDING or DESCENDING order. By default, the response will be sorted
        /// in DESCENDING order.
        /// </summary>
        [InQuery("sortOrder")]
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Filter by inbound shipment status.
        /// </summary>
        [InQuery("shipmentStatus")]
        public ShipmentStatus ShipmentStatus { get; set; }

        /// <summary>
        /// List the inbound shipments that were updated after a certain time (inclusive). The date must
        /// be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO 8601</a> format
        /// .
        /// </summary>
        [InQuery("updatedAfter")]
        public DateTimeValue UpdatedAfter { get; set; }

        /// <summary>
        /// List the inbound shipments that were updated before a certain time (inclusive). The date must
        /// be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO 8601</a> format
        /// .
        /// </summary>
        [InQuery("updatedBefore")]
        public DateTimeValue UpdatedBefore { get; set; }

        /// <summary>
        /// Maximum number of results to return.
        /// </summary>
        [InQuery("maxResults")]
        [Minimum(1)]
        [Maximum(200)]
        public int MaxResults { get; set; } = 25;

        /// <summary>
        /// A token that is used to retrieve the next page of results. The response includes `nextToken`
        /// when the number of results exceeds the specified `maxResults` value. To get the next page of
        /// results, call the operation with this token and include the same arguments as the call that
        /// produced the token. To get a complete list, call this operation until `nextToken` is null.
        /// Note that this operation can return empty pages.
        /// </summary>
        [InQuery("nextToken")]
        public string NextToken { get; set; }
    }
}
