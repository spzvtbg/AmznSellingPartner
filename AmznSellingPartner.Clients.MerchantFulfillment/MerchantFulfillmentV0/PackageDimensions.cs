namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using Newtonsoft.Json;

    /// <summary>
    /// The dimensions of a package contained in a shipment.
    /// </summary>
    public class PackageDimensions : BaseClass
    {
        /// <summary>
        /// The length dimension. If you don't specify `PredefinedPackageDimensions`, you must specify
        /// the length.
        /// </summary>
        [JsonProperty("Length")]
        public PackageDimension Length { get; set; }

        /// <summary>
        /// The width dimension. If you don't specify `PredefinedPackageDimensions`, you must specify the
        /// width.
        /// </summary>
        [JsonProperty("Width")]
        public PackageDimension Width { get; set; }

        /// <summary>
        /// The height dimension. If you don't specify `PredefinedPackageDimensions`, you must specify
        /// the height.
        /// </summary>
        [JsonProperty("Height")]
        public PackageDimension Height { get; set; }

        /// <summary>
        /// The unit of measurement. If you don't specify `PredefinedPackageDimensions`, you must specify
        /// the unit.
        /// </summary>
        [JsonProperty("Unit")]
        public UnitOfLength Unit { get; set; }

        [JsonProperty("PredefinedPackageDimensions")]
        public PredefinedPackageDimensions PredefinedPackageDimensions { get; set; }
    }
}
