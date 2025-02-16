namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}")]
    public class AmznGetInboundPlanRequest : BaseHttpRequest
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
    }
}
