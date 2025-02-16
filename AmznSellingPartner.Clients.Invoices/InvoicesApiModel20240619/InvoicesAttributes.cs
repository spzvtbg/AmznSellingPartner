namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// An object that contains the invoice attributes definition.
    /// </summary>
    public class InvoicesAttributes : BaseClass
    {
        /// <summary>
        /// A list of all the options that are available for the invoice status attribute.
        /// </summary>
        [JsonProperty("invoiceStatusOptions")]
        public List<AttributeOption> InvoiceStatusOptions { get; set; }

        /// <summary>
        /// A list of all the options that are available for the invoice type attribute.
        /// </summary>
        [JsonProperty("invoiceTypeOptions")]
        public List<AttributeOption> InvoiceTypeOptions { get; set; }

        /// <summary>
        /// A list of all the options that are available for the transaction identifier name attribute
        /// .
        /// </summary>
        [JsonProperty("transactionIdentifierNameOptions")]
        public List<AttributeOption> TransactionIdentifierNameOptions { get; set; }

        /// <summary>
        /// A list of all the options that are available for the transaction type attribute.
        /// </summary>
        [JsonProperty("transactionTypeOptions")]
        public List<AttributeOption> TransactionTypeOptions { get; set; }
    }
}
