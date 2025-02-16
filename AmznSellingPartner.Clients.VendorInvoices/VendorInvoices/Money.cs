namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
    using Newtonsoft.Json;

    /// <summary>
    /// An amount of money, including units in the form of currency.
    /// </summary>
    public class Money : BaseClass
    {
        /// <summary>
        /// Three-digit currency code in ISO 4217 format.
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("amount")]
        public Decimal Amount { get; set; }
    }
}
