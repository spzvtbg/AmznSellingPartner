namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using Newtonsoft.Json;

    /// <summary>
    /// Label details as part of the transport label response
    /// </summary>
    public class LabelData : BaseClass
    {
        /// <summary>
        /// A sequential number assigned to each label within a shipment.
        /// </summary>
        [JsonProperty("labelSequenceNumber")]
        public int LabelSequenceNumber { get; set; }

        /// <summary>
        /// The format of the label.
        /// </summary>
        [JsonProperty("labelFormat")]
        public LabelFormat LabelFormat { get; set; }

        /// <summary>
        /// Unique identification of the carrier.
        /// </summary>
        [JsonProperty("carrierCode")]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Tracking Id for the transportation.
        /// </summary>
        [JsonProperty("trackingId")]
        public string TrackingId { get; set; }

        /// <summary>
        /// The base-64 encoded string that represents the shipment label.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }
    }
}
