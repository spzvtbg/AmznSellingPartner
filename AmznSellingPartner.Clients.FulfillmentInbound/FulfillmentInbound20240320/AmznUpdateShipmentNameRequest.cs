namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPut("/inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/name")]
    public class AmznUpdateShipmentNameRequest : BaseHttpRequest
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
        /// Identifier of a shipment. A shipment contains the boxes and units being inbounded.
        /// </summary>
        [InPath("shipmentId")]
        [IsRequired]
        [MinLength(38)]
        [MaxLength(38)]
        [Pattern("^[a-zA-Z0-9-]*")]
        public string ShipmentId { get; set; }

        /// <summary>
        /// The body of the request to `updateShipmentName`.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public UpdateShipmentNameRequest Body { get; set; }
    }
}
