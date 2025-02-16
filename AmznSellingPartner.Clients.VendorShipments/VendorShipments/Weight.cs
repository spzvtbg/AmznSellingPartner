namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The weight of the shipment.
    /// </summary>
    public class Weight : BaseClass
    {
        /// <summary>
        /// The unit of measurement.
        /// </summary>
        [JsonProperty("unitOfMeasure")]
        [IsRequired]
        public UnitOfMeasure UnitOfMeasure { get; set; }

        /// <summary>
        /// The measurement value.
        /// </summary>
        [JsonProperty("value")]
        [IsRequired]
        public Decimal Value { get; set; }
    }
}
