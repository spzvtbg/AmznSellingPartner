namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/items")]
    public class AmznListInboundPlanItemsRequest : BaseHttpRequest
    {
        /// <summary>
        /// Identifier of an inbound plan.
        /// </summary>
        [InPath("inboundPlanId")]
        [IsRequired]
        [MinLength(38)]
        [MaxLength(38)]
        [Pattern("^[a-zA-Z0-9-]*")]
        public string InboundPlanId { get; set; }

        /// <summary>
        /// The number of items to return in the response matching the given query.
        /// </summary>
        [InQuery("pageSize")]
        [Minimum(1)]
        [Maximum(1000)]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// A token to fetch a certain page when there are multiple pages worth of results. The value of
        /// this token is fetched from the `pagination` returned in the API response. In the absence of
        /// the token value from the query parameter the API returns the first page of the result.
        /// </summary>
        [InQuery("paginationToken")]
        [MinLength(0)]
        [MaxLength(1024)]
        public string PaginationToken { get; set; }
    }
}
