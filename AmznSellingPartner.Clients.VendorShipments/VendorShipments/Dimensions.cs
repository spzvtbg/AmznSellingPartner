namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Physical dimensional measurements of a container.
    /// </summary>
    public class Dimensions : BaseClass
    {
        /// <summary>
        /// The length of the container.
        /// </summary>
        [JsonProperty("length")]
        [IsRequired]
        public Decimal Length { get; set; }

        /// <summary>
        /// The width of the container.
        /// </summary>
        [JsonProperty("width")]
        [IsRequired]
        public Decimal Width { get; set; }

        /// <summary>
        /// The height of the container.
        /// </summary>
        [JsonProperty("height")]
        [IsRequired]
        public Decimal Height { get; set; }

        /// <summary>
        /// The unit of measure for dimensions.
        /// </summary>
        [JsonProperty("unitOfMeasure")]
        [IsRequired]
        public UnitOfMeasure UnitOfMeasure { get; set; }
    }
}
