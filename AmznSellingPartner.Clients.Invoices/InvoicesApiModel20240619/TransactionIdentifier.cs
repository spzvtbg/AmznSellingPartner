namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
    using Newtonsoft.Json;

    /// <summary>
    /// The identifier for a transaction.
    /// </summary>
    public class TransactionIdentifier : BaseClass
    {
        /// <summary>
        /// The transaction identifier name. Use the `getInvoicesAttributes` operation to check `transactionIdentifierName`
        /// options.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The transaction identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
