namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    /// <summary>
    /// Contractual or operational port or point relevant to the movement of the cargo.
    /// </summary>
    public class Stop : BaseClass
    {
        /// <summary>
        /// Provide the function code.
        /// </summary>
        [JsonProperty("functionCode")]
        [IsRequired]
        public FunctionCode FunctionCode { get; set; }

        [JsonProperty("locationIdentification")]
        public Location LocationIdentification { get; set; }

        /// <summary>
        /// Date and time of the arrival of the cargo.
        /// </summary>
        [JsonProperty("arrivalTime")]
        public DateTimeValue ArrivalTime { get; set; }

        /// <summary>
        /// Date and time of the departure of the cargo.
        /// </summary>
        [JsonProperty("departureTime")]
        public DateTimeValue DepartureTime { get; set; }
    }
}
