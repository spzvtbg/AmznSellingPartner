namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// A quantity based on unit of measure.
    /// </summary>
    public class Amount : BaseClass
    {
        /// <summary>
        /// The unit of measure for the amount.
        /// </summary>
        [JsonProperty("unitOfMeasure")]
        [IsRequired]
        public UnitOfMeasure UnitOfMeasure { get; set; }

        /// <summary>
        /// The amount of a product in the associated unit of measure.
        /// </summary>
        [JsonProperty("value")]
        [IsRequired]
        public Decimal Value { get; set; }
    }
}
