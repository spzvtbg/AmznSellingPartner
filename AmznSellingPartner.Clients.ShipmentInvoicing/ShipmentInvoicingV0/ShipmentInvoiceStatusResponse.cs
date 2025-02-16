namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
    using Newtonsoft.Json;

    /// <summary>
    /// The shipment invoice status response.
    /// </summary>
    public class ShipmentInvoiceStatusResponse : BaseClass
    {
        [JsonProperty("Shipments")]
        public ShipmentInvoiceStatusInfo Shipments { get; set; }
    }
}
