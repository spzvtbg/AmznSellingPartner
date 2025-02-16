namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// A list of one or more ShipmentLabels.
    /// </summary>
    public class TransportLabel : BaseClass
    {
        /// <summary>
        /// Date on which label is created.
        /// </summary>
        [JsonProperty("labelCreateDateTime")]
        public DateTimeValue LabelCreateDateTime { get; set; }

        /// <summary>
        /// Indicates the shipment Information details like warehouse and business reference details like
        /// ARN, Selling Party detail and Vendor Warehouse details
        /// </summary>
        [JsonProperty("shipmentInformation")]
        public ShipmentInformation ShipmentInformation { get; set; }

        /// <summary>
        /// Indicates the label data,format and type associated .
        /// </summary>
        [JsonProperty("labelData")]
        public List<LabelData> LabelData { get; set; }
    }
}
