namespace AmznSellingPartner.Clients.Sales.Sales
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The currency type and the amount.
    /// </summary>
    public class Money : BaseClass
    {
        /// <summary>
        /// Three-digit currency code. In ISO 4217 format.
        /// </summary>
        [JsonProperty("currencyCode")]
        [IsRequired]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The currency amount.
        /// </summary>
        [JsonProperty("amount")]
        [IsRequired]
        public Decimal Amount { get; set; }
    }
}
