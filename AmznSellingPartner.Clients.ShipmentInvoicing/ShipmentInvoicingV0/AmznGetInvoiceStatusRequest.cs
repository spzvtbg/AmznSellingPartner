namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/fba/outbound/brazil/v0/shipments/{shipmentId}/invoice/status")]
    public class AmznGetInvoiceStatusRequest : BaseHttpRequest
    {
        /// <summary>
        /// The shipment identifier for the shipment.
        /// </summary>
        [InPath("shipmentId")]
        [IsRequired]
        public string ShipmentId { get; set; }
    }
}
