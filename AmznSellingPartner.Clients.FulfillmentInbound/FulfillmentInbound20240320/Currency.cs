namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The type and amount of currency.
    /// </summary>
    public class Currency : BaseClass
    {
        /// <summary>
        /// Decimal value of the currency.
        /// </summary>
        [JsonProperty("amount")]
        [IsRequired]
        public double Amount { get; set; }

        /// <summary>
        /// ISO 4217 standard of a currency code.
        /// </summary>
        [JsonProperty("code")]
        [IsRequired]
        [MinLength(3)]
        [MaxLength(3)]
        public string Code { get; set; }
    }
}
