namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Measurement information for an order item.
    /// </summary>
    public class Measurement : BaseClass
    {
        /// <summary>
        /// The unit of measure.
        /// </summary>
        [JsonProperty("Unit")]
        [IsRequired]
        public Unit Unit { get; set; }

        /// <summary>
        /// The measurement value.
        /// </summary>
        [JsonProperty("Value")]
        [IsRequired]
        public double Value { get; set; }
    }
}
