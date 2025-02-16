namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    /// <summary>
    /// Expiry refers to the collection of dates required  for certain items. These could be either
    /// expiryDate or mfgDate and expiryAfterDuration. These are mandatory for perishable items.
    /// </summary>
    public class Expiry : BaseClass
    {
        /// <summary>
        /// Production, packaging or assembly date determined by the manufacturer. Its meaning is determined
        /// based on the trade item context.
        /// </summary>
        [JsonProperty("manufacturerDate")]
        public DateTimeValue ManufacturerDate { get; set; }

        /// <summary>
        /// The date that determines the limit of consumption or use of a product. Its meaning is determined
        /// based on the trade item context.
        /// </summary>
        [JsonProperty("expiryDate")]
        public DateTimeValue ExpiryDate { get; set; }

        /// <summary>
        /// Duration after manufacturing date during which the product is valid for consumption.
        /// </summary>
        [JsonProperty("expiryAfterDuration")]
        public Duration ExpiryAfterDuration { get; set; }
    }
}
