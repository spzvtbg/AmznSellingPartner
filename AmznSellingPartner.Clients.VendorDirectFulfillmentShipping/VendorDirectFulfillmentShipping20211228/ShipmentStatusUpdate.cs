namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Represents an update to the status of a shipment.
    /// </summary>
    public class ShipmentStatusUpdate : BaseClass
    {
        /// <summary>
        /// Purchase order number of the shipment for which to update the shipment status.
        /// </summary>
        [JsonProperty("purchaseOrderNumber")]
        [IsRequired]
        [Pattern("^[a-zA-Z0-9]+")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// ID of the selling party or vendor.
        /// </summary>
        [JsonProperty("sellingParty")]
        [IsRequired]
        public PartyIdentification SellingParty { get; set; }

        /// <summary>
        /// Warehouse code of vendor.
        /// </summary>
        [JsonProperty("shipFromParty")]
        [IsRequired]
        public PartyIdentification ShipFromParty { get; set; }

        /// <summary>
        /// Provide the details about the status of the shipment at that particular point of time.
        /// </summary>
        [JsonProperty("statusUpdateDetails")]
        [IsRequired]
        public StatusUpdateDetails StatusUpdateDetails { get; set; }
    }
}
