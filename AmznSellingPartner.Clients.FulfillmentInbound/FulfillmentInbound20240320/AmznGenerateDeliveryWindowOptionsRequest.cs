namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/deliveryWindowOptions")]
    public class AmznGenerateDeliveryWindowOptionsRequest : BaseHttpRequest
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
        /// The shipment to generate delivery window options for.
        /// </summary>
        [InPath("shipmentId")]
        [IsRequired]
        [MinLength(38)]
        [MaxLength(38)]
        [Pattern("^[a-zA-Z0-9-]*")]
        public string ShipmentId { get; set; }
    }
}
