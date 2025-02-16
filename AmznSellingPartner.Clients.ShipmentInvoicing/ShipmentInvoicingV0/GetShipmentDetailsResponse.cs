namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the getShipmentDetails operation.
    /// </summary>
    public class GetShipmentDetailsResponse : BaseClass
    {
        /// <summary>
        /// The payload for the getShipmentDetails operation
        /// </summary>
        [JsonProperty("payload")]
        public ShipmentDetail Payload { get; set; }

        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
